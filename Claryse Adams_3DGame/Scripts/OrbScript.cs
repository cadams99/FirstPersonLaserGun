/*************************************************************************
 * AUTHOR: Claryse Adams
 * DESCRIPTION: Script attached to PowerOrbs. Makes them
 *  disappear when shot
 ************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScript : MonoBehaviour
{
    private bool shot; //was the orb shot?

    // Start is called before the first frame update
    void Start()
    {
        shot = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void disappear()
    {
        if (shot == false) //has this cube been collected yet?
        {//Increment the number of items that the player has collected a
         //cube by calling the SetItemsCollected method in the PlayerScript
            GetComponent<Renderer>().enabled = false; //Make the cube disappear
            shot = true; //Update that the cube has been collected
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip); //play sound when shot
        }

    }

    public bool IsShot()
    {
        return shot;
    }
}
