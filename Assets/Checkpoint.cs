using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Target;
    int i = 0;

 
    void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(Target[0].GetComponent<Transform>().position);
    }


    // Update is called once per frame
    void Update()
    {
        if (GetComponent<NavMeshAgent>().remainingDistance < 3)
        {
            i++;
            GetComponent<NavMeshAgent>().SetDestination(Target[i].GetComponent<Transform>().position);
           
        }

    }
            

}
