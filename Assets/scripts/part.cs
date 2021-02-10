using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class part : MonoBehaviour
{

    public ParticleSystem geraaktp1;
    public ParticleSystem geraaktp2;
    public ParticleSystem shotfirep1;
    public ParticleSystem shotfirep2;

    public static bool hitp1;
    public static bool hitp2;
    public static bool shotp1;
    public static bool shotp2;



    // Start is called before the first frame update
    void Start()
    {
        hitp1 = false;
        hitp2 = false;
        shotp1 = false;
        shotp2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hitp1 == true)
        {
            geraaktp1.Play();
            hitp1 = false;
        }
        if (hitp2 == true)
        {
            geraaktp2.Play();
            hitp2 = false;
        }
        if (shotp1 == true)
        {
            shotfirep1.Play();
            shotp1 = false;
        }
        if (shotp2 == true)
        {
            shotfirep2.Play();
            shotp2 = false;
        }
    }

    
}
