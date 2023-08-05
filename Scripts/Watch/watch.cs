using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class watch : MonoBehaviour
{
    public Player_inven player_Inven; // �÷��̾� �κ��丮 ��ũ��Ʈ

    [Header("�� ������Ʈ")]
    [SerializeField] private GameObject seconds_object; // �ð��� �ʿ� �ش��ϴ� ������Ʈ

    [Header("�� ������Ʈ")]
    [SerializeField] private GameObject minutes_object; // �ð��� �п� �ش��ϴ� ������Ʈ

    [Header("�Ϸ� ��")]
    [SerializeField] private float time; // ���� �ð�

    [Header("�ִ� ��")]
    [SerializeField] private float reset_time; // �ʱ�ȭ �Ǵ� �ð�

    public AudioSource timer_sound; // �ð� ����

    private float seconds_Drainage_one; // ���� ��
    private float minutes_Drainage_one; // ���� ��

    private float minutes; // ��
    
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
