using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class boat_fuel : MonoBehaviour
{
    [SerializeField] private GameObject[] BoatFuelObject; // 보트 배터리 오브젝트
    [SerializeField] private GameObject BoatWheelObjecy; // 보트 조타륜 오브젝트

    public int boatnowfuel; // 보트 현재 배터리 갯수
    const int boatfuelmax = 10; // 보트 최대치 배터리 갯수

    public int boatnowwheel; // 보트 현재 조타륜 갯수
    const int boatwheelmax = 1; // 보트 최대치 조타륜 갯수

    [SerializeField] private Image familyimage; // 가족 사진
    [SerializeField] private TMP_Text[] boatnowcontents; // 보트의 현재 상황

    private void Start()
    {
        boatnowfuel = 0;
        boatnowwheel = 0;
        
        boatnowcontents[0].text = $"충전된 배터리 : {boatnowfuel}";
        boatnowcontents[1].text = $"필요한 배터리 : {boatfuelmax - boatnowfuel}";
        boatnowcontents[2].text = string.Empty;
        boatnowcontents[3].text = $"조타륜 : {boatnowwheel}";
    }

    public void Boatfuelplus() // 보트 배터리 증가 함수
    {
        if (boatnowfuel < boatfuelmax)
        {
            boatnowfuel++;
            for (int i = 0;i < boatnowfuel; ++i)
            {                
                BoatFuelObject[i].gameObject.SetActive(true);
            }                        
        }
        else if (boatnowfuel == boatfuelmax)
        {            
            boatnowcontents[2].text = "배터리 충전이 완료되었습니다";
        }
        boatnowcontents[0].text = $"충전된 배터리 : {boatnowfuel}";
        boatnowcontents[1].text = $"필요한 배터리 : {boatfuelmax - boatnowfuel}";        
    }

    public void Boatwheelplus() // 보트 조타륜 증가 함수
    {
        if (boatnowwheel < boatwheelmax)
        {
            boatnowwheel++;
            for (int i = 0; i < boatnowwheel; ++i)
            {
                BoatWheelObjecy.gameObject.SetActive(true);
            }
        }
        else if (boatnowwheel == boatwheelmax)
        {

        }
        boatnowcontents[3].text = $"조타륜 : {boatnowwheel}";
    }

    public void Boatgo() // 보트 출발 함수
    {
        if (boatnowfuel == boatfuelmax)
        {
            familyimage.enabled = true;
        }
    }    
}
