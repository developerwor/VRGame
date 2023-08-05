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
    public Robot robot_object; // �κ� ������Ʈ ����Ʈ
    
    public GameObject robot_talk_panel; // �κ��� �г�
    public TMP_Text robot_text; // TMP �ؽ�Ʈ

    public GameObject robot; // ��Ź��, �����

    [SerializeField] private NavMeshAgent robot_agent; // ���� ������Ʈ�� �׺�޽�

    [SerializeField] private Transform[] robot_move_position; // �κ��� ������ ��ġ    

    public float Select_time; // �κ��� �ٽ� ������ȯ�Ͽ� ������ �ð�
    public float time; // ���� �ð�

    private int AI_Position; // ���° �κ�
    private int number_Random; // ���° �κ����� �������� ���Ѱ��� �Ҵ����

    public int ainowfeul; // ai�� ���� ���᰹��
    public const int aimaxfeul = 1; // ai�� �ִ뿬�� ������

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
            Debug.Log("�κ� ������ �����" + gameObject.name);
        }
    }

    public void agent_stop()
    {        
        robot_talk_panel.SetActive(true);
        robot_agent.isStopped = true;
        Debug.Log("�κ� ������ ����" + gameObject.name);
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
            robot_text.text = "���ʱ⸦ �����̷��� ���� 1���� �ʿ��մϴ� \n ���Ḧ �����Ͻðڽ��ϱ�?";
        }
        if (robot_object == Robot.Mower)
        {
            robot_text.text = "���ʱ⸦ �����̷��� ���� 1���� �ʿ��մϴ� \n ���Ḧ �����Ͻðڽ��ϱ�?";
        }
        if (robot_object == Robot.refrigerator)
        {
            robot_text.text = "����� �����̷��� ���� 1���� �ʿ��մϴ� \n ���Ḧ �����Ͻðڽ��ϱ�?";
        }
        if (robot_object == Robot.vending_machine)
        {
            robot_text.text = "���Ǳ⿡�� ���������� ���� 1���� �ʿ��մϴ� \n ���Ḧ �����Ͻðڽ��ϱ�?";
        }
        if (robot_object == Robot.warshmachine)
        {
            robot_text.text = "��Ź�⸦ �����̷��� ���� 1���� �ʿ��մϴ� \n ���Ḧ �����Ͻðڽ��ϱ�?";
        }
    }
}