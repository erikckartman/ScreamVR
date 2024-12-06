using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Human : MonoBehaviour
{
    [SerializeField] private Transform player;
    private NavMeshAgent agent;
    private float speed = 1f;
    private float range = 10f;
    public int Life = 10;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance < range)
        {
            Vector3 direction = transform.position - player.position;
            Vector3 fleeDestination = transform.position + direction.normalized * range;

            agent.SetDestination(fleeDestination);
        }

        if(Life <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void Damage(int damage)
    {
        Life -= damage;
        if (damage  < 0)
        {
            damage = 0;
        }
    }
}
