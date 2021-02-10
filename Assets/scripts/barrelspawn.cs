using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelspawn : MonoBehaviour
{
    public float timer = 15;
    public GameObject sharkPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(sharkPrefab, new Vector3(Random.Range(-6, 6), 6f, 0f), transform.rotation);
            timer = 20;
        }

    }
}
