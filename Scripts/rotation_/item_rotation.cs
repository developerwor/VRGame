using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_rotation : MonoBehaviour
{
    [SerializeField] private GameObject item; // 플레이 공간에서의 아이템 오브젝트
    [SerializeField] private float speed; // 아이템 오브젝트 회전 스피드
    void Update()
    {
        item.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
