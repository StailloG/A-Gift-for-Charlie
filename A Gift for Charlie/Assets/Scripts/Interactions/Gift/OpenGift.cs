/*
 * Set this script to gift box
 * 
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

    [Header("Animation")]
    public Animator setAnim;
    
    public void Start()
    {
        setAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (near == true && Input.GetKeyDown(KeyCode.E) && clickOnce < 1)
        {
            clickOnce++;
            OpenGiftAnim();
        }
    }

    public void OpenGiftAnim()
    {
        setAnim.SetBool("OpenGift", true);
    }
}
