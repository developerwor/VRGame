using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Chararter_move : MonoBehaviour
{

    private CharacterController characterController; // ���� ������Ʈ�� ĳ���� ��Ʈ�ѷ�

    [SerializeField] private Vector3 directation;
    [SerializeField] private float Speed;
    private float Gravity = -9.81f;      


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //charactercontroller_move();
       // isground_check();
    }

    private void charactercontroller_move()
    {
        characterController.Move(directation * Speed * Time.deltaTime);
    }

    public void charactercontroller_Vector3(Vector3 vector)
    {
        directation = vector;
    }

    private void isground_check()
    {
        if (characterController.isGrounded == false)
        {
            Debug.LogError("ĳ���Ͱ� ���� �پ� �����ʽ��ϴ�");
            directation.y += Gravity * Time.deltaTime;
        }
    }
}
*/