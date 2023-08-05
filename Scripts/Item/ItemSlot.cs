using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public bool hasItem; // ai�� ���ᰡ ���� ���� üũ
    public GameObject inItem; // �κ� ������

    private void Start()
    {
        hasItem = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasItem == false && other.CompareTag("item"))
        {         
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;

            inItem = other.gameObject;

            hasItem = true;
        }
    }   

    private void OnTriggerExit(Collider other)
    {
        if (hasItem == true && other.CompareTag("item"))
        {
            if (other.gameObject == inItem)
            {
                inItem = null;

                hasItem = false;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
