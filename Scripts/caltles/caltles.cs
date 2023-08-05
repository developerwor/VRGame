using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class caltles : MonoBehaviour
{
    [Header("���� ������Ʈ")]
    public GameObject castle_object; // ���� ������Ʈ
        

    [Header("���� �ӵ�")]
    [Range(0, 10)]
    public float open_speed; // ������ �������� ���ǵ�

    [Header("Ȳ���� ��������")]
    public float caltles_Robot_feul; // ���� �κ��� ���� ������

    [Header("��ȭ �г�")]
    public GameObject talk_panel; // ���� �κ��� ��ȭ �г�

    [Header("text_move")]
    public cales_text_move text_Move; // ���� �κ��� ��ȭ �ӵ�

    private Vector3 vector3; // ������ �������� �����ϴ� ��ġ

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
