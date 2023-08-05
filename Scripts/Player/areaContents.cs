using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class areaContents : MonoBehaviour
{
    [SerializeField] private Vector3 responposition; // 플레이어가 영역 밖으로 떨어졌을때의 귀환 위치
    #region 현재는 사용하지 않는 코드
    //[SerializeField] private tree_delete tree;
    ////public TMP_Text areaalarmtext;
    //[SerializeField] float restarttime;

    //float popTime = 1.0f;
    //float nowTime = 0;

    #endregion

    private void OnTriggerStay(Collider other)
    {
        #region 현재는 사용하지 않는 코드

        /*nowTime += Time.deltaTime;

        print("스테이 영역");
        if (other.gameObject.CompareTag("startarea"))
        {
            print("startarea");
            if (nowTime > popTime)
            {
                if (tree.gameObject.activeSelf == true)
                {
                    areaalarmtext.text = "다리를 건널려고 한다면 연료를 찾아서 \n 예초기한태 연료를 주입해야돼!";
                }
                else
                {
                    areaalarmtext.text = "나무가 사라졌으니 다리를 건너세요";
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
                areaalarmtext.text = "배를 가동할려고 한다면 연료 5개와 조타륜 1개가 필요해!";
                areaalarmtext.gameObject.SetActive(!areaalarmtext.gameObject.activeSelf);
                nowTime = 0;
            }
        }
        else if (other.gameObject.CompareTag("island"))
        {
            print("island");
            if (nowTime > popTime)
            {
                areaalarmtext.text = "미션과 생존을 위해서 연료/코인/조타륜을 찾아!";
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