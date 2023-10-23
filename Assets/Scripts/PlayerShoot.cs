using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private float canFire;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] arrows;

    private void Update()
    {
        // Update the cooldown timer.

        // Check if the player can attack.
        if (Input.GetKey(KeyCode.Space) && Time.time > canFire)
        {
            Attack();
        }
    }

    private void Attack()
    {
        // Reset the cooldown timer.
        canFire = Time.time + fireRate;

        // Find an available arrow to shoot.
        int arrowIndex = FindArrow();
        if (arrowIndex != -1)
        {
            arrows[arrowIndex].transform.position = firePoint.position;
            arrows[arrowIndex].GetComponent<PlayerProjectile>().ActivateProjectile();
        }

    }

    private int FindArrow()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            if (!arrows[i].activeInHierarchy)
            {
                return i; // Return the index of the available arrow.
            }
        }
        return -1; // Return -1 if no available arrow is found.
    }
}