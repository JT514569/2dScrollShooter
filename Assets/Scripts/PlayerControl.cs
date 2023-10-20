using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] public float MoveSpeed;
    private BoxCollider2D boxCollider;
    private Rigidbody2D body;
    public static Animator anim;
    public Rigidbody2D rb;
    public Level mylevel;
    public GameObject GameOver;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void Awake()
    {
        //Grab refs for rigidbody and animator
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
            if (collision.tag == "Enemy")
            {
                Debug.Log("Player hit");
                GameOver.SetActive(true);
                gameObject.SetActive(false);
            }
    }

    void Start()
    {
        StartCoroutine(AnimLevel());
    }

    
     IEnumerator  AnimLevel()
    {
        yield return new WaitUntil(() => mylevel.level == 2);
        Debug.Log("Anim change");
        anim.SetInteger("LVL", 2);
        yield return new WaitUntil(() => mylevel.level == 3);
        Debug.Log("Anim change");
        anim.SetInteger("LVL", 3);
        yield return new WaitUntil(() => mylevel.level == 4);
        Debug.Log("Anim change");
        anim.SetInteger("LVL", 4);

    }
}
