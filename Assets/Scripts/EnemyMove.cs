using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private BoxCollider2D boxCollider;
    private Rigidbody2D body;
    public static Animator anim;

    private void Awake()
    {
        //Grab refs for rigidbody and animator
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }


    // Update is called once per frame
    private void Update()
    {
        float movementSpeed = (speed * -1) * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Enemy")
        {
            if (collision.tag == "Delete")
            {
                Debug.Log("Deleted");
                Destroy(this.gameObject);
            }
        }
    }
}
