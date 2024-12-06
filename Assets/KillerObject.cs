using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerObject : MonoBehaviour
{
    private Human human;
    public int damageAmount = 5;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("object named" + other.name + "Hash collided");
        
        human = other.gameObject.GetComponent<Human>();
            if (human != null)
            {
                human.Damage(damageAmount);
                Debug.Log(other.name + "was damaged for" + damageAmount);
            }
    }
}
