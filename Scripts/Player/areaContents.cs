using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class areaContents : MonoBehaviour
{
    [SerializeField] private Vector3 responposition; // �÷��̾ ���� ������ ������������ ��ȯ ��ġ
    #region ����� ������� �ʴ� �ڵ�
    //[SerializeField] private tree_delete tree;
    ////public TMP_Text areaalarmtext;
    //[SerializeField] float restarttime;

    //float popTime = 1.0f;
    //float nowTime = 0;

    #endregion

    private void OnTriggerStay(Collider other)
    {
        #region ����� ������� �ʴ� �ڵ�

        /*nowTime += Time.deltaTime;

        print("������ ����");
        if (other.gameObject.CompareTag("startarea"))
        {
            print("startarea");
            if (nowTime > popTime)
            {
                if (tree.gameObject.activeSelf == true)
                {
                    areaalarmtext.text = "�ٸ��� �ǳη��� �Ѵٸ� ���Ḧ ã�Ƽ� \n ���ʱ����� ���Ḧ �����ؾߵ�!";
                }
                else
                {
                    areaalarmtext.text = "������ ��������� �ٸ��� �ǳʼ���";
                }
                
                areaalarmtext.gameObject.SetActive(!areaalarmtext.gameObject.activeSelf);
                nowTime = 0;
            }          
        }
        else if (other.gameObject.CompareTag("Harbor"))
        {
            print("Harbor");
            if (nowTime > popTime)
            {
                areaalarmtext.text = "�踦 �����ҷ��� �Ѵٸ� ���� 5���� ��Ÿ�� 1���� �ʿ���!";
                areaalarmtext.gameObject.SetActive(!areaalarmtext.gameObject.activeSelf);
                nowTime = 0;
            }
        }
        else if (other.gameObject.CompareTag("island"))
        {
            print("island");
            if (nowTime > popTime)
            {
                areaalarmtext.text = "�̼ǰ� ������ ���ؼ� ����/����/��Ÿ���� ã��!";
                areaalarmtext.gameObject.SetActive(!areaalarmtext.gameObject.activeSelf);
                nowTime = 0;
            }
        }
   */
        #endregion

        if (other.CompareTag("warterarea") || other.CompareTag("outsidearea"))
        {
            gameObject.transform.position = responposition;
        }
    }
}