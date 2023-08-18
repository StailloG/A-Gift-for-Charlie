/*
 * Play the box opening animation when:
 *  1. the player is near the gift box
 *      &
 *  2. the player presses 'E'
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGift : MonoBehaviour
{
    public PlayerNearGift near;
    public int clickOnce = 0;

    void Update()
    {
        if (near == true && Input.GetKeyDown(KeyCode.E) && clickOnce < 1)
        {
            OpenGiftAnim();
            clickOnce++;
        }
    }

    public void OpenGiftAnim()
    {
        //animation
        Debug.Log("Animation of box moving!!");
    }
}
