using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class caltles : MonoBehaviour
{
    [Header("성문 오브젝트")]
    public GameObject castle_object; // 성문 오브젝트
        

    [Header("성문 속도")]
    [Range(0, 10)]
    public float open_speed; // 성문이 열릴때의 스피드

    [Header("황복순 에너지원")]
    public float caltles_Robot_feul; // 성문 로봇의 현재 에너지

    [Header("대화 패널")]
    public GameObject talk_panel; // 성문 로봇의 대화 패널

    [Header("text_move")]
    public cales_text_move text_Move; // 성문 로봇의 대화 속도

    private Vector3 vector3; // 성문이 열릴떄의 도달하는 위치

    void Start()
    {
        caltles_Robot_feul = 0;
        talk_panel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talk_panel.SetActive(true);
            text_Move.befor_catles_Text_animation();            
        }        
    }

    public void castle_Open()
    {
        castle_object.gameObject.transform.position = Vector3.Lerp(castle_object.gameObject.transform.position, vector3, open_speed * Time.deltaTime);        
    }

    public void castle_close(Vector3 vector3)
    {
        //castle_object.gameObject.transform.position = Vector3.Lerp(castle_object.gameObject.transform.position, vector3, open_speed * Time.deltaTime);        
    }    
}
