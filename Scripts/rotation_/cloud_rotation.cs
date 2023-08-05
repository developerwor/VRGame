using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_rotation : MonoBehaviour
{
    [SerializeField] private GameObject cloud; // ���� ������Ʈ
    [SerializeField] private float speed; // ���� ������Ʈ�� ȸ�� ���ǵ�
        
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
            Debug.LogError("���� ȸ���� ���ӿ�����Ʈ�� �������� �ʽ��ϴ�.");
        }
    }
}
