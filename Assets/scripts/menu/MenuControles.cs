using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuControles : MonoBehaviour
{
 public void HowToLoad()
    {
        SceneManager.LoadScene(1);
    }
public void MenuLoad()
    {
        SceneManager.LoadScene(0);
    }
public void Gameload()
    {
        P1M.scoreP1 = 0;
        P1M.hpP1 = 3;
        P2M.scoreP2 = 0;
        P2M.hpP2 = 3;
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
