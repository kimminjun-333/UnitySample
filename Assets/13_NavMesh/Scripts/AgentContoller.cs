using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentContoller : MonoBehaviour
{
    public Transform pointer;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //AI에게 특정 지점으로 이동하도록 하는 함수
        agent.SetDestination(pointer.position);
        agent.isStopped = isStop;
    }

    public bool isStop;

}
