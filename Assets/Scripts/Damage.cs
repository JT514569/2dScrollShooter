using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] public float damage;
    public Health health;
    public Level Levelmy;
    public float DamageNumb;
    [SerializeField] private AudioSource Bam;

    public void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.tag == "Projectile")
        {
            Debug.Log("Enemy hurt");
            if (Levelmy.level == 1)
            {
                DamageNumb = 1;
            }
            else if (Levelmy.level == 2)
            {
                DamageNumb = 2;
            }
            else if (Levelmy.level == 3)
            {
                DamageNumb = 5;
            }
            else
            {
                DamageNumb = 10;
            }
            health.Damage(DamageNumb);
            Bam.Play();
            Score.instance.AddPoint(5);
            // collision.GetComponent<Health>().Damage(damage);

        }
    }

}
