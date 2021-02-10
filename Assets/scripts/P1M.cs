using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1M : MonoBehaviour
{
    public static float hpP1 = 3f;
    public static float scoreP1 = 0f;
    public Text ScoreText;
    public Text HpText;

    public AudioSource sfxHitS;
    public AudioClip sfxHit;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HpText.text = ": " + hpP1;
        ScoreText.text = "" + scoreP1;

        
        

        if((hpP1 == 0) || hpP1 < 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }


        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletP2")
        {
            sfxHitS.PlayOneShot(sfxHit);
        }
    }
}
