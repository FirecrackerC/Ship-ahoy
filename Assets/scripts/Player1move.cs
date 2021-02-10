using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player1move : MonoBehaviour
{
    public static float xmove;
    public static float ymove;
    public static float inputx;
    public static float inputy;

    public static int speedx;
    public static int speedy;
    public Rigidbody2D rb;

    



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speedx = 15;
        speedy = 15;
    }

    private void FixedUpdate()
    {

        inputx = Input.GetAxis("Horizontal") * speedx;
        inputy = Input.GetAxis("Vertical") * speedy;
        xmove = inputx * 10f * Time.deltaTime;
        ymove = inputy * 10f * Time.deltaTime;
        rb.velocity = new Vector2(xmove, ymove);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
