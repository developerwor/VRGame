using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_rotation : MonoBehaviour
{
    [SerializeField] private GameObject item; // �÷��� ���������� ������ ������Ʈ
    [SerializeField] private float speed; // ������ ������Ʈ ȸ�� ���ǵ�
    void Update()
    {
        item.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
