using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : Damage
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;
    [SerializeField] public SpriteRenderer mySprite;


    //public Health health;
    public void ActivateProjectile()
    {
        lifetime = 0;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (base.Levelmy.level == 1)
        {
            mySprite.color = Color.white;
        }
        else if (base.Levelmy.level == 2)
        {
            mySprite.color = Color.yellow;
        }
        else if (base.Levelmy.level == 3)
        {
            mySprite.color = Color.red;
        }
        else
        {
            mySprite.color = Color.magenta;
        }
        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > resetTime)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Projectile")
            if (collision.tag == "Enemy")
            {
                Debug.Log("Enemy hit");
                base.OnTriggerEnter2D(collision);
                gameObject.SetActive(false);
            }
    }
}
