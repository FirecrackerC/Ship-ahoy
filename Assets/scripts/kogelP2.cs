using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kogelP2 : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    public AudioSource sfxHits;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right  * -speed;
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            sfxHits.Play();
            part.hitp1 = true;
            P2M.scoreP2 += 500;
            P1M.hpP1--;
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
