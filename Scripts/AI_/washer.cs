using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class washer : MonoBehaviour
{
    [SerializeField] private GameObject destipostion; // �κ��� ���� ��ġ ������Ʈ
    [SerializeField] private GameObject panel; // �κ��� �г�
    [SerializeField] private Player_inven player_Inven; // Player_inven ��ũ��Ʈ
    [SerializeField] private NavMeshAgent refrigertornavmesh; // ���� ������Ʈ�� �׺�Ž�

    [SerializeField] private Animator animator;

    [SerializeField] private Vector3 stoppos;

    public interectorble_grip interectorble_Grip;

    public float nowfuel;

    private void Awake()
    {
        nowfuel = 0;
    }
    private void Start()
    {
        refrigertornavmesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (nowfuel == 1)
        {
            refrigertornavmesh.SetDestination(destipostion.gameObject.transform.position);
            animator.SetBool("start", true);
            if (gameObject.transform.position == destipostion.gameObject.transform.position)
            {
                animator.SetBool("start", false);
            }
            
        }
        else
        {
            animator.SetBool("start", false);
        }
    }

    public void fuelplus()
    {
        if (player_Inven.fuel > 0 && nowfuel == 0)
        {
            player_Inven.fuel--;
            nowfuel++;
            interectorble_Grip.delde();
            panel.SetActive(false);
        }
    }
}
