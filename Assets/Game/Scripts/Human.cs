using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Human : MonoBehaviour
{
    [SerializeField] private GameObject knife;
    [SerializeField] private Transform player;
    private NavMeshAgent agent;
    private float range = 10f;
    public int Life = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == knife)
        {
            Debug.Log("KILL");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance < 10f)
        {

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
