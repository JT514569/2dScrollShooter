using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float StartHP;
    public float currentHP { get; private set; }
    public Animator anim;
    private bool dead;
   // private new GameObject gameObject; 
                
    private SpriteRenderer spriteRend;
   // [SerializeField] private AudioSource HurtSound;
   // [SerializeField] private AudioSource DeathSound;
   [SerializeField] private string sceneName;
    private void Awake()
    {
        currentHP = StartHP;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }
    public void Damage(float _damage)
    {
        currentHP = Mathf.Clamp(currentHP - _damage, 0, StartHP);

        if (currentHP > 0)
        {
            //anim.SetTrigger("Hurt");
          //  HurtSound.Play();

        }
        else
        {
            Destroy(this.gameObject);
                //anim.SetTrigger("Die");
           //     DeathSound.Play();
               //dead = true;
                
                //Player


        }
    }

    public void PlayerDead()
    {
        SceneManager.LoadScene(sceneName);
    }
}