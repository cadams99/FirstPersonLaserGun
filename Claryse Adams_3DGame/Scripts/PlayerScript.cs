/*************************************************************************
 * AUTHOR: Claryse Adams
 * DESCRIPTION: Script attached to FPSController. Mainly used to
 *  track how many orbs player has shot and maintain UI
 ************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private int orbsShot; //number of orbs player has shot
    public Text message; //track orbs shot
    public float timeLeft = 120.0f; //gives player two minutes to collect orbs
    public Text timerText; // used for showing time

    // Start is called before the first frame update
    void Start()
    {
        orbsShot = 0; //Initialize orbs shot
        message.text = "Orbs Left: 10"; //Initialize the Text
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) //press esc to quit game
            Application.Quit();

        message.text = "Orbs Left: " + (10 - orbsShot); //update number of orbs shot 

        if(orbsShot >= 1) //start/update timer after first orb is shot
            timeLeft -= Time.deltaTime;

        //win condition
        if (orbsShot == 10)
        {
            timerText.text = "You Win!";
        }

        //update timerText
        else
        {
            timerText.text = "        " + (timeLeft).ToString("0");

            //lose condition
            if (timeLeft <= 0)
            {
                timerText.text = "You Lose!";
            }
        }
    }

    public int GetOrbsShot()
    {
        return orbsShot;
    }

    public void IncrementOrbs()
    {
        orbsShot++;
    }
}
