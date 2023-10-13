using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : Damage
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;

    //public Health health;
    public void ActivateProjectile()
    {
        lifetime = 0;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > resetTime)
        {
            gameObject.SetActive(false);
        }
    }

    /*
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Projectile")
            if (collision.tag == "Enemy")
            {
                Debug.Log("Enemy hit");
                health.Damage(10f);
                base.OnTriggerEnter2D(collision);
                gameObject.SetActive(false);
            }
    }
    */
}
