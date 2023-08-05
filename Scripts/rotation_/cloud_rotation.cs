using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_rotation : MonoBehaviour
{
    [SerializeField] private GameObject cloud; // 구름 오브젝트
    [SerializeField] private float speed; // 구름 오브젝트의 회전 스피드
        
    void Update()
    {
        Rotation_methed();
    }

    private void Rotation_methed()
    {
        if (cloud != null)
        {
            cloud.gameObject.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            Debug.LogError("현재 회전할 게임오브젝트가 존재하지 않습니다.");
        }
    }
}
