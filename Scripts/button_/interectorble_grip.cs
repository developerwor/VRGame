using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class interectorble_grip : MonoBehaviour
{
    [SerializeField] private Player_inven player_Inven; // 플레이어 인벤토리 스크립트
    [SerializeField] private TMP_Text talk_box; // tmp 텍스트 유형
    [SerializeField] private AudioSource itemgetsound; // 아이템을 획득할때 사용하는 오디오 소스

    GameObject grabobject = null; // 아이템을 획득할 오브젝트        

    public void SelectEnterEvent(SelectEnterEventArgs Event)
    {
        Event.interactable.GetComponent<Collider>().isTrigger = true;

        grabobject = Event.interactable.gameObject;
     
        if (Event.interactable.gameObject.name.Contains("fuel"))
        {            
            if (player_Inven.fuel >= 20)
            {
                talk_box.text = "현재 배터리가 너무 많아서 담을수가 없습니다.";
            }
            else
            {
                player_Inven.fuel++;
                itemgetsound.Play();
            }
        }
        else if (Event.interactable.gameObject.name.Contains("coin"))
        {
            if (player_Inven.coin >= 20)
            {
                talk_box.text = "현재 코인이 너무 많아서 담을수가 없습니다.";
            }
            else
            {
                player_Inven.coin++;
                itemgetsound.Play();
            }
        }
        else if (Event.interactable.gameObject.name.Contains("steering_wheel_item00"))
        {
            if (player_Inven.steering_wheel >= 1)
            {
                talk_box.text = "현재 조타륜을 담을수 없습니다.";
            }
            else
            {
                player_Inven.steering_wheel++;
                itemgetsound.Play();
            }
        }
    }    

    public void SelectExitEvent(SelectExitEventArgs Event)
    {
        Event.interactable.GetComponent<Collider>().isTrigger = false;

        if (Event.interactable.gameObject.name.Contains("fuel"))
        {
            if (player_Inven.fuel == 0)
            {
                talk_box.text = "현재 배터리가 없어서 버릴수가 없습니다.";
            }
            else
            {
                player_Inven.fuel--;
            }
        }
        else if (Event.interactable.gameObject.name.Contains("coin"))
        {
            if (player_Inven.coin == 0)
            {
                talk_box.text = "현재 코인이 없어서 버릴수가 없습니다.";
            }
            else
            {
                player_Inven.coin--;
            }
        }
        else if (Event.interactable.gameObject.name.Contains("steering_wheel_item00"))
        {
            if (player_Inven.steering_wheel == 0)
            {
                talk_box.text = "현재 조타륜이 없어서 버릴수가 없습니다.";
            }
            else
            {
                player_Inven.steering_wheel--;
            }
        }        
    }
    public void delde()
    {
        Destroy(grabobject);
        print(grabobject.name);
    }    
}