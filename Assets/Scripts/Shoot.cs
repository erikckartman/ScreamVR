using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private InputAction shootAction;


    private void OnEnable()
    {
        shootAction.Enable();
        shootAction.performed += OnShoot;
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("BANG!!!");
        GameObject bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(bulletClone, 3f);
    }
}
