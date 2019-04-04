﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent; 

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();       
    }

    // Update is called once per frame
    void Update()
    {
        //的の目的地にターゲットの位置を設定
        agent.destination = target.transform.position;
    }
}
