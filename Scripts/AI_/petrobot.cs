using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
public class petrobot : MonoBehaviour
{
    [SerializeField] private GameObject Player; // �÷��̾�
    [SerializeField] private GameObject Petpanel; // �� �г�
    [SerializeField] private TMP_Text pettext; // �� ��Ʈ

    public interectorble_grip interectorble_Grip; // interectorble_grip ��ũ��Ʈ
    private NavMeshAgent Petagent; // �� �׺�޽�
    
    
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
        pettext.text = "���Ḧ �������ּ���";
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
