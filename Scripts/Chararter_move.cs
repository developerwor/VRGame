using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Chararter_move : MonoBehaviour
{

    private CharacterController characterController; // 현재 오브젝트의 캐릭터 컨트롤러

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
            Debug.LogError("캐릭터가 땅에 붙어 있지않습니다");
            directation.y += Gravity * Time.deltaTime;
        }
    }
}
*/