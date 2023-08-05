using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_fuel_post : MonoBehaviour
{
    public const int aiMaxFuel = 1; // 로봇의 최대 연료
    public int aiNowFuel; // 로봇이 현재 보유하고 있는 연료
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
