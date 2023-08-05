using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
public class petrobot : MonoBehaviour
{
    [SerializeField] private GameObject Player; // 플레이어
    [SerializeField] private GameObject Petpanel; // 펫 패널
    [SerializeField] private TMP_Text pettext; // 펫 멘트

    public interectorble_grip interectorble_Grip; // interectorble_grip 스크립트
    private NavMeshAgent Petagent; // 펫 네비메쉬
    
    
    public int petfuel;
    private void Start()
    {
        Petagent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        
        if (petfuel == 1)
        {            
            Petagent.SetDestination(Player.gameObject.transform.position);
        }
    }    

    private void OnTriggerEnter(Collider other)
    {
        Petpanel.SetActive(true);
        pettext.text = "연료를 주입해주세요";
        if (petfuel == 1)
        {
            Petpanel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Petpanel.SetActive(false);
    }

    public void InjectionButton()
    {
        if (petfuel == 0)
        {         
            petfuel++;
            interectorble_Grip.delde();
            Petpanel.SetActive(false);            
        }        
    }
}
