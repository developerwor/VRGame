using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class refrigertormove : MonoBehaviour
{
    [SerializeField] private GameObject destipostion; // 이동 위치
    [SerializeField] private GameObject panel; // 패널
    [SerializeField] private Player_inven player_Inven; // 플레이어 인벤토리 스크립트
    [SerializeField] private NavMeshAgent refrigertornavmesh; // 현재 오브젝트의 네비메쉬
    
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
