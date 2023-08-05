using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum text_robot
{
    refrigerator,
    washer
}

public class cales_text_move : MonoBehaviour
{
    public text_robot text_Robot_name; // 로봇 리스트
    public TMP_Text talk_box; // 성문 앞의 로봇 멘트1
    public TMP_Text talk_box_; // 성문 앞의 로봇 멘트2

    public float time;

    private void Start()
    {        
        talk_box_.text = $"현재 성 로봇 배터리 보유 갯수 : 0";
    }
    void Update()
    {
        time += Time.deltaTime;
        
    }

    public void befor_catles_Text_animation()
    {
        StartCoroutine(Text_while_one("성문오픈 조건 : 연료 5개 \n 주입하겠습니까?"));
    }

    public void after_catles_Text_animation()
    {
        StartCoroutine(Text_while_two("조건이 성립되었으므로 성문을 개방합니다!"));
    }

    IEnumerator Text_while_one(string text)
    {
        while (talk_box.text != text)
        {
            yield return null;
            string void_text = "";
            float talk_time;
            talk_time = 0.2f;
            for (int i = 0; i < text.Length; i++)
            {
                if (time > talk_time)
                {
                    void_text += text[i];
                    talk_box.text = void_text;
                    talk_time += 0.2f;
                }
            }
        }
    }

    IEnumerator Text_while_two(string text)
    {
        while (talk_box.text != text)
        {
            yield return null;
            string void_text = "";
            float talk_time;
            talk_time = 0.2f;
            for (int i = 0; i < text.Length; i++)
            {
                if (time > talk_time)
                {
                    void_text += text[i];
                    talk_box.text = void_text;
                    talk_time += 0.2f;
                }
            }
        }
    }

    public void nowfuel(float robotfuel)
    {
        talk_box_.text = $"현재 성 로봇 배터리 보유 갯수 : {robotfuel}";
    }
}
