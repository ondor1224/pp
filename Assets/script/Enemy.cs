using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public Transform Target;
    NavMeshAgent nav;
    Rigidbody rb;
    
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        nav.stoppingDistance = 5;
        if (Target != null)
        {
            nav.SetDestination(Target.position);
        }
    }

   

}
