using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class refrigertormove : MonoBehaviour
{
    [SerializeField] private GameObject destipostion; // �̵� ��ġ
    [SerializeField] private GameObject panel; // �г�
    [SerializeField] private Player_inven player_Inven; // �÷��̾� �κ��丮 ��ũ��Ʈ
    [SerializeField] private NavMeshAgent refrigertornavmesh; // ���� ������Ʈ�� �׺�޽�
    
    public interectorble_grip interectorble_Grip;

    public float nowfuel;

    private void Awake()
    {
        nowfuel = 0;
    }
    private void Start()
    {        
        refrigertornavmesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (nowfuel == 1)
        {
            refrigertornavmesh.SetDestination(destipostion.gameObject.transform.position);
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
