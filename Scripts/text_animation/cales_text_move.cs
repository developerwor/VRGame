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
    public text_robot text_Robot_name; // �κ� ����Ʈ
    public TMP_Text talk_box; // ���� ���� �κ� ��Ʈ1
    public TMP_Text talk_box_; // ���� ���� �κ� ��Ʈ2

    public float time;

    private void Start()
    {        
        talk_box_.text = $"���� �� �κ� ���͸� ���� ���� : 0";
    }
    void Update()
    {
        time += Time.deltaTime;
        
    }

    public void befor_catles_Text_animation()
    {
        StartCoroutine(Text_while_one("�������� ���� : ���� 5�� \n �����ϰڽ��ϱ�?"));
    }

    public void after_catles_Text_animation()
    {
        StartCoroutine(Text_while_two("������ �����Ǿ����Ƿ� ������ �����մϴ�!"));
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
        talk_box_.text = $"���� �� �κ� ���͸� ���� ���� : {robotfuel}";
    }
}
