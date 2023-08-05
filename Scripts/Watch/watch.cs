using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class watch : MonoBehaviour
{
    public Player_inven player_Inven; // 플레이어 인벤토리 스크립트

    [Header("초 오브젝트")]
    [SerializeField] private GameObject seconds_object; // 시계의 초에 해당하는 오브젝트

    [Header("분 오브젝트")]
    [SerializeField] private GameObject minutes_object; // 시계의 분에 해당하는 오브젝트

    [Header("하루 분")]
    [SerializeField] private float time; // 현재 시간

    [Header("최대 분")]
    [SerializeField] private float reset_time; // 초기화 되는 시간

    public AudioSource timer_sound; // 시계 사운드

    private float seconds_Drainage_one; // 현재 초
    private float minutes_Drainage_one; // 현재 분

    private float minutes; // 분
    
    void Start()
    {
        time = 0;
        
        minutes_Drainage_one = 0;
        seconds_Drainage_one = 0;

        minutes = 0;
    }

    void Update()
    {        
        time_method();                  
    }

    private void time_method()
    {
        if (time > seconds_Drainage_one)
        {
            seconds_Drainage_one++;
            seconds_object.transform.Rotate(Vector3.forward, 6);            
        }

        if (minutes > minutes_Drainage_one)
        {
            minutes_Drainage_one++;
            minutes_object.transform.Rotate(Vector3.forward, 30);
        }
        time += Time.deltaTime;
        if (time > 60)
        {            
            time = 0;
            minutes += 1;
            seconds_Drainage_one = 0;
        }

        if (minutes == reset_time)
        {            
            minutes = 0;
            time = 0;
            minutes_Drainage_one = 0;
            player_Inven.rice--;
        }
    }
}
