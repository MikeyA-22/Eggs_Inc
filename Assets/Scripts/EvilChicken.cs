using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilChicken : MonoBehaviour, IChicken
{
    private Transform goal;
    public NavMeshAgent agent;
    private IChicken _chickenImplementation;

    // Start is called before the first frame update
    void Start()
    {
        
        if (GameObject.FindGameObjectWithTag("Chicken") == null)
        {
            goal = GameObject.FindGameObjectWithTag("Goal").transform;
        }
        else
        {
            goal = GameObject.FindGameObjectWithTag("Chicken").transform;    
        }
        
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
        if (other.tag == "Chicken")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Goal")
        {
            Destroy(this.gameObject);
        }
    }
}
