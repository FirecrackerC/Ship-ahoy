using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatshieldp2 : MonoBehaviour
{


    public float speed = 5f;
    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * -speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletP1")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Ship")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Shark")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "nobullet")
        {
            Destroy(gameObject);
        }

    }
}
