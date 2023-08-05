using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AI_ment : MonoBehaviour
{
    private NavMeshAgent robot_agent; // 로봇의 네비메쉬 에이전트

    private Vector3 move_vector3;   

    private void Start()
    {
        robot_agent = GetComponent<NavMeshAgent>();
    }
        
    private void OnTriggerStay(Collider other)
    { 
        agent_stop();
    }

    private void OnTriggerExit(Collider other)
    {     
        agent_start();
    }
    
    public void agent_start()
    {        
        robot_agent.isStopped = false;
    }
    
    public void agent_stop()
    {
        robot_agent.isStopped = true;
    }
}
