using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public AudioSource sfxHits;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
        speed = speed * Time.deltaTime;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            sfxHits.Play();
            P1M.hpP1--;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Ship2")
        {
            sfxHits.Play();
            P2M.hpP2--;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BulletP1")
        {
            P1M.scoreP1 += 100;
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "BulletP2")
        {
            P2M.scoreP2 += 100;
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "nobullet")
        {
            Destroy(gameObject);
        }
        
    }

}
