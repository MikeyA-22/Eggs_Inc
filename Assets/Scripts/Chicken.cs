using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour, IChicken
{
    private Transform goal;
    public NavMeshAgent agent;
    private IChicken _chickenImplementation;

    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Goal").transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;
        
    }


    public void Move()
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("working");
        
        if (other.tag == "Goal")
        {
            Destroy(this.gameObject);
        }
    }
}
