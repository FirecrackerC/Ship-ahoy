using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2move : MonoBehaviour
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

        inputx = Input.GetAxis("Horizontal2") * speedx;
        inputy = Input.GetAxis("Vertical2") * speedy;
        xmove = inputx * 10f * Time.deltaTime;
        ymove = inputy * 10f * Time.deltaTime;
        rb.velocity = new Vector2(xmove, ymove);
    }
}
