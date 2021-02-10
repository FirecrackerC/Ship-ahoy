using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P2M : MonoBehaviour
{
    public static float hpP2 = 3f;
    public static float scoreP2 = 0f;
    public Text HpText;
    public Text ScoreText;

    public AudioSource sfxHitS;
    public AudioClip sfxHit;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HpText.text = hpP2 + " :";
        ScoreText.text = "" + scoreP2;

        if ((hpP2 == 0) || hpP2 < 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletP1")
        {
            sfxHitS.PlayOneShot(sfxHit);
        }
    }
}
