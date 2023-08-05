using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
public enum current_situation
{
    spandrel, // ����
    full_stomach // ����
}

public class Player_inven : MonoBehaviour
{
    public current_situation current_Situation; // �÷��̾��� ����

    public float coin; // ���� ����
    public float rice; // ���� ��
    public float fuel; // ���� ����
    public float steering_wheel; // ���� ��Ÿ��

    public float time; // ���� �ð�
    public float time_rice_reset; // �� ���� �ð�

    public string current_text; // ���� �÷��̾� ���¸� �ؽ�Ʈ�� ǥ��

    public TMP_Text[] Item_array; // ������ ���¸� ǥ��
    
    public ContinuousMoveProviderBase XR_Player_move_code; // XR ȯ�濡���� �̵��� ��Ʈ��
    public ContinuousTurnProviderBase XR_Player_turn_code; // XR ȯ�濡���� ȸ���� ��Ʈ��
    private void Awake()
    {
        gameObject.transform.position = new Vector3(-26.5f, 236.5f, 358.8f);
        StartCoroutine(time_now());
    }
    private void Start()
    {
        current_Situation = current_situation.full_stomach;
    }
    void Update()
    {   
        Item();
        current_Situation_method();        
    }

    public void Item() // ���� ������ ���� ��Ȳ
    {
        Item_array[0].text = $"���� : {coin}";
        Item_array[1].text = $"�� : {rice}";
        Item_array[2].text = $"���� : {fuel}";

        
        if (time_rice_reset >= 300f) // ���� : �Ϸ� ����
        {
            time_rice_reset = 0;
            if (rice > 0)
            {
                rice--;
            }
            
        }        
    }

    public void current_Situation_method() // ������ ���� / ������ ����
    {
        if (rice > 0)
        {
            current_Situation = current_situation.full_stomach;
        }
        else if (rice == 0)
        {
            current_Situation = current_situation.spandrel;
        }
        else if (rice < 0 || fuel < 0 || coin < 0)
        {
            Debug.Log($"���� �����ϰ� �ִ� �������� ������ rice : {rice} / coin : {coin} / Battery : {fuel}�Դϴ�");
            Debug.Log(" ������ �߻��߽��ϴ� �ڵ带 �ٽ� ������ ���ֽñ� �ٶ��ϴ�");
        }
        if (current_Situation == current_situation.full_stomach)
        {
            XR_Player_move_code.moveSpeed = 50;
            XR_Player_turn_code.turnSpeed = 60;

            current_text = "���� ���� �����Դϴ�";
        }
        else if (current_Situation == current_situation.spandrel)
        {
            XR_Player_move_code.moveSpeed = 40;
            XR_Player_turn_code.turnSpeed = 50;

            current_text = "���� �������� �Դϴ�";
        }
        Item_array[2].text = current_text;
    }

    IEnumerator time_now()
    {        
        while (true)
        {
            time += Time.deltaTime;
            time_rice_reset += Time.deltaTime;
            yield return time;
        }        
    }
}
