using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vending_machine : MonoBehaviour
{
    public Player_inven player_Inven; // �÷��̾��� �κ��丮 ��ũ��Ʈ
    private float vending_rice; // vendingmachine�� ����

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
                Debug.Log("���� ���ԵǾ����ϴ�");
            }
            else
            {
                Debug.Log("���� ���Ǳ⿡ ���������� �����ϴ�.");
            }            
        }
        else
        {
            Debug.Log("���� �����Ҽ��ִ� ������ ������ �����մϴ�");
        }
    }
}
