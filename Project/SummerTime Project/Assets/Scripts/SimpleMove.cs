﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleMove : MonoBehaviour
{
    public Animator anim;
   
    public NavMeshAgent myNavMeshAgent;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            SetDestinationToMousePosition();
            Debug.Log(this.GetComponent<Transform>().position);
        }
       
    }
    void SetDestinationToMousePosition()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            myNavMeshAgent.SetDestination(hit.point);
            Debug.Log(hit.point);
        }
    }

    void Attack()
    {
       float dis = Vector3.Distance(this.GetComponent<Transform>().position, hit.point);
        Debug.Log(dis);
       if (dis<0.3)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", true);
        }
        
    }
}
