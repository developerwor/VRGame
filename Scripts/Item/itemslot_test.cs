using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemslot_test : MonoBehaviour
{
    public ItemSlot[] _slot;
    public bool check = false; // 연료 체크
    private void Start()
    {
        _slot = GetComponentsInChildren<ItemSlot>();
        check = false;
    }

    bool fuel_check()
    {
        int checkfuel = 0;

        for (int i = 0; i < _slot.Length; i++)
        {
            if (_slot[i].hasItem)
                checkfuel += 1;
        }
        if (_slot.Length <= checkfuel)
            return true;

        return false;
    }
    
    private void Update()
    {
        check = fuel_check();
    }
}


