using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
public enum current_situation
{
    spandrel, // 공복
    full_stomach // 만복
}

public class Player_inven : MonoBehaviour
{
    public current_situation current_Situation; // 플레이어의 상태

    public float coin; // 보유 코인
    public float rice; // 보유 밥
    public float fuel; // 보유 연료
    public float steering_wheel; // 보유 조타륜

    public float time; // 현재 시간
    public float time_rice_reset; // 밥 소진 시간

    public string current_text; // 현재 플레이어 상태를 텍스트로 표시

    public TMP_Text[] Item_array; // 아이템 상태를 표시
    
    public ContinuousMoveProviderBase XR_Player_move_code; // XR 환경에서의 이동을 컨트롤
    public ContinuousTurnProviderBase XR_Player_turn_code; // XR 환경에서의 회전을 컨트롤
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

    public void Item() // 현재 아이템 갯수 현황
    {
        Item_array[0].text = $"코인 : {coin}";
        Item_array[1].text = $"밥 : {rice}";
        Item_array[2].text = $"연료 : {fuel}";

        
        if (time_rice_reset >= 300f) // 조건 : 하루 마다
        {
            time_rice_reset = 0;
            if (rice > 0)
            {
                rice--;
            }
            
        }        
    }

    public void current_Situation_method() // 공복시 상태 / 만복시 상태
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
            Debug.Log($"현재 보유하고 있는 아이템의 갯수는 rice : {rice} / coin : {coin} / Battery : {fuel}입니다");
            Debug.Log(" 오류가 발생했습니다 코드를 다시 재점검 해주시길 바랍니다");
        }
        if (current_Situation == current_situation.full_stomach)
        {
            XR_Player_move_code.moveSpeed = 50;
            XR_Player_turn_code.turnSpeed = 60;

            current_text = "현재 만복 상태입니다";
        }
        else if (current_Situation == current_situation.spandrel)
        {
            XR_Player_move_code.moveSpeed = 40;
            XR_Player_turn_code.turnSpeed = 50;

            current_text = "현재 공복상태 입니다";
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
