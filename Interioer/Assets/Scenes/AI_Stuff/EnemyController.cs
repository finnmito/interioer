using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;
    public bool playerInSightRange;
    public Transform target;
    NavMeshAgent agent;
    public LayerMask whatIsGround, whatIsPlayer;



    // Start is called before the first frame update
    private void Awake()
    {
        target = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, lookRadius, whatIsPlayer);
        if (playerInSightRange) Chasing();
/*         target = GetComponent<Transform>();
        float distance = Vector3.Distance(target.position,transform.position);
        if (distance <= lookRadius){
            agent.SetDestination(target.position);
        } */
    }

    private void Chasing(){
        agent.SetDestination(target.position);
    }

/*     void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius);
    } */
}
