using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Shoot : MonoBehaviour
{
    public Transform fireLocation;
    public Transform fireLocationup;
    public Transform fireLocationdown;
    public GameObject cannonBallPrefab;
    public GameObject meatshieldPrefab;

    public static bool canshoot;
    public static float timer;
    public static float cooldowntimer;
    public float rappidcooldown;

    public AudioSource sfxFireS;
    public AudioClip sfxFire;
    public AudioSource sfxMeatshieldS;
    public AudioClip sfxMeatshield;

    public Slider reload;

    public Transform powerUpPos;
    public GameObject powerUpT;
    public GameObject powerUpB;

    void Start()
    {
        timer = 0f;
        cooldowntimer = 3f;
        rappidcooldown = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        reload.value = timer;

        if(barrel.powerupp1 == true && barrel.randompowerup == 1)
        {
            powerUpB.transform.position = powerUpPos.transform.position;
        }

        if (barrel.powerupp1 == true && barrel.randompowerup == 2)
        {
            powerUpT.transform.position = powerUpPos.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            Shoot();
            cooldown();
            part.shotp1 = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && timer <= 0 && barrel.powerupp1 == true && barrel.randompowerup == 1)
        {
            StartCoroutine("rappidfire");
            cooldown();
            powerUpB.transform.position = new Vector3(0, -600, 0);
            part.shotp1 = true;
            barrel.randompowerup = 0;
            barrel.powerupp1 = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && timer <= 0 && barrel.powerupp1 == true && barrel.randompowerup == 2)
        {
            spreadshot();
            cooldown();
            powerUpT.transform.position = new Vector3(0, -600, 0);
            part.shotp1 = true;
            barrel.randompowerup = 0;
            barrel.powerupp1 = false;
        }

        if (Input.GetKeyDown(KeyCode.R) && timer <= 0)
        {
            meatshield();
            cooldown();
            part.shotp1 = true;
        }



        if (timer > 0f)
        {
            timer = timer - Time.deltaTime;
        }


        
        

    }


    void meatshield()
    {
        sfxMeatshieldS.PlayOneShot(sfxMeatshield);
        Instantiate(meatshieldPrefab, fireLocation.position, fireLocation.rotation);
        
    }
    void Shoot()
    {
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        
    }
    void spreadshot()
    {
        sfxFireS.PlayOneShot(sfxFire); 
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocationup.position, fireLocationup.rotation);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocationdown.position, fireLocationdown.rotation);
    }
    IEnumerator rappidfire()
    {
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        yield return new WaitForSeconds(rappidcooldown);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        yield return new WaitForSeconds(rappidcooldown);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        yield return new WaitForSeconds(rappidcooldown);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        yield return new WaitForSeconds(rappidcooldown);
        sfxFireS.PlayOneShot(sfxFire);
        Instantiate(cannonBallPrefab, fireLocation.position, fireLocation.rotation);
        yield return new WaitForSeconds(rappidcooldown);

    }
    void cooldown()
    {
        timer = cooldowntimer;
        
    }




}
