using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
public enum Robot
{
    refrigerator,
    warshmachine,
    vending_machine,
    Mower,
    MowerUFO,
    Pet
}
public class Robot_Ai : MonoBehaviour
{
    public Robot robot_object; // 로봇 오브젝트 리스트
    
    public GameObject robot_talk_panel; // 로봇의 패널
    public TMP_Text robot_text; // TMP 텍스트

    public GameObject robot; // 세탁기, 냉장고

    [SerializeField] private NavMeshAgent robot_agent; // 현재 오브젝트의 네비메쉬

    [SerializeField] private Transform[] robot_move_position; // 로봇이 움직일 위치    

    public float Select_time; // 로봇이 다시 방향전환하여 움직일 시간
    public float time; // 현재 시간

    private int AI_Position; // 몇번째 로봇
    private int number_Random; // 몇번째 로봇인지 랜덤으로 정한값을 할당받음

    public int ainowfeul; // ai의 현재 연료갯수
    public const int aimaxfeul = 1; // ai의 최대연료 보유값

    private void Awake()
    {
        ainowfeul = 0;  
        AI_Position = 0;
    }
    void Start()
    {        
        robot_agent = GetComponent<NavMeshAgent>();
        agent_stop();
        robot_talk_panel.SetActive(false);        
    }
    void Update()
    {
        number_Random = Random.Range(0, robot_move_position.Length);        
        robot_Ai(number_Random);        
        AITalkPanel();
    }

    private void robot_Ai(int randomnumber)
    {
        
        time += Time.deltaTime;

        AI_Position = randomnumber;
        if (robot != null)
        {
            if (time >= Select_time)
            {               

                Vector3 dest = robot_move_position[AI_Position].position;
                Debug.Log(dest);
                robot_agent.SetDestination(dest);

                time = 0;

                
                if (number_Random >= 2)
                {
                    AI_Position--;
                }
                else if (number_Random <= 2)
                {
                    AI_Position++;
                }
                else
                {
                    time = 3;
                }                
            }
        }
        else
        {
            Debug.LogError(robot + "not SetActive");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            robot_talk_panel.SetActive(true);

            if (robot_object == Robot.Pet && ainowfeul > 0)
            {
                robot_agent.SetDestination(other.transform.position);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            robot_talk_panel.SetActive(false);            
        }
    }

    public void agent_start()
    {       
        if (ainowfeul == aimaxfeul)
        {            
            robot_talk_panel.SetActive(false);
            robot_agent.isStopped = false;
            Debug.Log("로봇 움직임 재시작" + gameObject.name);
        }
    }

    public void agent_stop()
    {        
        robot_talk_panel.SetActive(true);
        robot_agent.isStopped = true;
        Debug.Log("로봇 움직임 멈춤" + gameObject.name);
    }
    public void SetDest(GameObject desti)
    {
        robot_agent.SetDestination(desti.transform.position);
    }

    /*
    public void SetRandDest()
    {
        number_Random = Random.Range(0, robot_move_position.Length);
        robot_agent.SetDestination(robot_move_position[AI_Position].position);
    }
    */

    public void AITalkPanel()
    {
        if (robot_object == Robot.MowerUFO)
        {
            robot_text.text = "예초기를 움직이려면 연료 1개가 필요합니다 \n 연료를 제공하시겠습니까?";
        }
        if (robot_object == Robot.Mower)
        {
            robot_text.text = "예초기를 움직이려면 연료 1개가 필요합니다 \n 연료를 제공하시겠습니까?";
        }
        if (robot_object == Robot.refrigerator)
        {
            robot_text.text = "냉장고를 움직이려면 연료 1개가 필요합니다 \n 연료를 제공하시겠습니까?";
        }
        if (robot_object == Robot.vending_machine)
        {
            robot_text.text = "자판기에서 에너지원을 연료 1개가 필요합니다 \n 연료를 제공하시겠습니까?";
        }
        if (robot_object == Robot.warshmachine)
        {
            robot_text.text = "세탁기를 움직이려면 연료 1개가 필요합니다 \n 연료를 제공하시겠습니까?";
        }
    }
}