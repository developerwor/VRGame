using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refrigeratorarm : MonoBehaviour
{
    [SerializeField] private GameObject arm; // ����� ��
    [SerializeField] private float speed; // ȸ�� ���ǵ�
    void Update()
    {
        arm.transform.Rotate(Vector3.right, speed);
    }
}
