using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] public float damage;
    public Health health;

    public void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.tag == "Projectile")
        {
            Debug.Log("Enemy hurt");

            health.Damage(10f);
            // collision.GetComponent<Health>().Damage(damage);

        }
    }

}
