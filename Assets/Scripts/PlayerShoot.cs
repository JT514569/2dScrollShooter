using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] arrows;
    private float cooldownTimer;

    private void Update()
    {
        // Update the cooldown timer.
        cooldownTimer -= Time.deltaTime;

        // Check if the player can attack.
        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        if  (cooldownTimer <= 0)
        {
            // Reset the cooldown timer.
            cooldownTimer = attackCooldown;

            // Find an available arrow to shoot.
            int arrowIndex = FindArrow();
            if (arrowIndex != -1)
            {
                arrows[arrowIndex].transform.position = firePoint.position;
                arrows[arrowIndex].GetComponent<PlayerProjectile>().ActivateProjectile();
            }
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