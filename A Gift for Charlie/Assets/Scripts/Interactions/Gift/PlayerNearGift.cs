/*
 * Determines if player is near gift
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNearGift : MonoBehaviour
{
    public bool near = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            near = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            near = false;
        }
    }
}
