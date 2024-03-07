using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{
    public NavMeshAgent agent;

    public LayerMask whatIsGroung;

    //Patroling 
    Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    private void Update()
    {
        Patroling();
    }

    private void Patroling()
    {
        if(!walkPointSet) SearchWalkPoint();

       if(walkPointSet) 
            agent.SetDestination(walkPoint);

       Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached 
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        //Search for the random walkpoint
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        //Check if walkpoint is in range
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGroung))
            walkPointSet = true;
    }
}
