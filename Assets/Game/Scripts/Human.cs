using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private GameObject knife;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == knife)
        {
            Debug.Log("KILL");
            Destroy(gameObject);
        }
    }
}
