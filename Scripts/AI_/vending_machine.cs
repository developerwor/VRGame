using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vending_machine : MonoBehaviour
{
    public Player_inven player_Inven; // 플레이어의 인벤토리 스크립트
    private float vending_rice; // vendingmachine의 연료

    private void Start()
    {
        vending_rice = 1;
    }
    public void Rice_buy()
    {
        if (player_Inven.coin > 0)
        {                        
            if (vending_rice == 1)
            {
                player_Inven.coin--;
                player_Inven.rice++;
                vending_rice--;
                Debug.Log("밥이 구입되었습니다");
            }
            else
            {
                Debug.Log("현재 자판기에 에너지원이 없습니다.");
            }            
        }
        else
        {
            Debug.Log("현재 구입할수있는 코인의 갯수가 부족합니다");
        }
    }
}
