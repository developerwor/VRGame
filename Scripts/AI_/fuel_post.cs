using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_fuel_post : MonoBehaviour
{
    public const int aiMaxFuel = 1; // �κ��� �ִ� ����
    public int aiNowFuel; // �κ��� ���� �����ϰ� �ִ� ����
    void Start()
    {
        aiNowFuel = 0;
    }            
    
    public void AIFuelPlus()
    {
        if (aiNowFuel < aiMaxFuel)
        {
            aiNowFuel++;
        }
    }
}
