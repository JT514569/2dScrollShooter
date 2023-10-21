using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    private void Update()
    {
        float movementSpeed = (speed * -1) * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Enemy")
            if (collision.tag == "Delete")
            {
                Debug.Log("Deleted");
                Destroy(this.gameObject);
            }
    }
}
