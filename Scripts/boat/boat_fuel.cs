using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class boat_fuel : MonoBehaviour
{
    [SerializeField] private GameObject[] BoatFuelObject; // ��Ʈ ���͸� ������Ʈ
    [SerializeField] private GameObject BoatWheelObjecy; // ��Ʈ ��Ÿ�� ������Ʈ

    public int boatnowfuel; // ��Ʈ ���� ���͸� ����
    const int boatfuelmax = 10; // ��Ʈ �ִ�ġ ���͸� ����

    public int boatnowwheel; // ��Ʈ ���� ��Ÿ�� ����
    const int boatwheelmax = 1; // ��Ʈ �ִ�ġ ��Ÿ�� ����

    [SerializeField] private Image familyimage; // ���� ����
    [SerializeField] private TMP_Text[] boatnowcontents; // ��Ʈ�� ���� ��Ȳ

    private void Start()
    {
        boatnowfuel = 0;
        boatnowwheel = 0;
        
        boatnowcontents[0].text = $"������ ���͸� : {boatnowfuel}";
        boatnowcontents[1].text = $"�ʿ��� ���͸� : {boatfuelmax - boatnowfuel}";
        boatnowcontents[2].text = string.Empty;
        boatnowcontents[3].text = $"��Ÿ�� : {boatnowwheel}";
    }

    public void Boatfuelplus() // ��Ʈ ���͸� ���� �Լ�
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
            boatnowcontents[2].text = "���͸� ������ �Ϸ�Ǿ����ϴ�";
        }
        boatnowcontents[0].text = $"������ ���͸� : {boatnowfuel}";
        boatnowcontents[1].text = $"�ʿ��� ���͸� : {boatfuelmax - boatnowfuel}";        
    }

    public void Boatwheelplus() // ��Ʈ ��Ÿ�� ���� �Լ�
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
        boatnowcontents[3].text = $"��Ÿ�� : {boatnowwheel}";
    }

    public void Boatgo() // ��Ʈ ��� �Լ�
    {
        if (boatnowfuel == boatfuelmax)
        {
            familyimage.enabled = true;
        }
    }    
}
