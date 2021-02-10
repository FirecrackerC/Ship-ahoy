using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kogel : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    public AudioSource sfxHits;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ship2")
        {
            sfxHits.Play();
            part.hitp2 = true;
            P1M.scoreP1 += 500;
            P2M.hpP2--;
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Shark")
        {
            sfxHits.Play();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "nobullet")
        {
            Destroy(gameObject);
        }
        
    }
}
