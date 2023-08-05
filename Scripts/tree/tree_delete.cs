using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_delete : MonoBehaviour
{
    [SerializeField] private areaContents areaContents; // areaContents 스크립트
    public Robot_Ai robot; // Robot_Ai

    public float tree_del = 5;
    [SerializeField] private float life;

    Vector3 size_oflife; // 나무 사이즈
    float minSize = 2f; // 나무 최소사이즈

    float check_dest = 1.0f; // 나무가 줄어들기 시작하는 딜레이 시간

    public float time; // 나무가 줄어들기 시작하는 시간
    private void Start()
    {
        size_oflife = gameObject.transform.localScale / (tree_del + minSize);
        life = tree_del;

        time = check_dest;
    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mower"))
        {
            robot = other.GetComponent<Robot_Ai>();

            if (robot != null)
            {
                robot.SetDest(gameObject);
            }            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Mower"))
        {
            if (robot != null)
            {
                print("나무 stay" + robot.name);
                if (time > check_dest)
                {
                    time = 0;

                    life -= 1.0f;

                    gameObject.transform.localScale = size_oflife * (life + minSize);
                    
                    if (life <= 0)
                    {
                        gameObject.SetActive(false);                        
                    }
                }
            }
        }
    }    
}
