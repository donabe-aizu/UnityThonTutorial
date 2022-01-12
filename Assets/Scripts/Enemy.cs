using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // 目的地となるGameObjectをセットします。
    public Transform target;
    private NavMeshAgent agent; 

    void Start()
    {
        // Nav Mesh Agent を取得します。
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // targetに向かって移動します。
        agent.SetDestination(target.position);
    }
}
