using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_rotation : MonoBehaviour
{
    public GameObject rice_buy_button; // 구입 버튼
    public float button_speed; // 버트의 회전 스피드

    private void Start()
    {
        rice_buy_button.SetActive(false);
    }
    void Update()
    {
        rice_buy_button.transform.Rotate(Vector3.up,Time.deltaTime * button_speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            rice_buy_button.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        rice_buy_button.SetActive(false);
    }
}
