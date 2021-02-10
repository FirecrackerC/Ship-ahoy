using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text pWin;
    public Text score;
    private string Winner;
    private string sWinner;

    // Start is called before the first frame update
    void Start()
    {
        if(P1M.hpP1 > P2M.hpP2)
        {
            Winner = "1";
            sWinner = "" + P1M.scoreP1;
        }
        else if(P2M.hpP2 > P1M.hpP1)
        {
            Winner = "2";
            sWinner = "" + P2M.scoreP2;
        }

        pWin.text = "Player " + Winner + " wins!";
        score.text = "Their score was: " + sWinner;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
