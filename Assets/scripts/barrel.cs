using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public static int randompowerup;
    public static bool powerupp1;
    public static bool powerupp2;

    public AudioSource pU;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        randompowerup = 0;
        speed = 0.2f;
    }

    private void Update()
    {
        speed = speed * Time.deltaTime;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "BulletP1")
        {
            pU.Play();
            randompowerup = Random.Range(1, 3);
            powerupp1 = true;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "BulletP2")
        {
            pU.Play();
            randompowerup = Random.Range(1, 3);
            powerupp2 = true;
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "nobullet")
        {
            Destroy(gameObject);
        }

    }

}
