using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player movement variables
    private float speed = 20;
    private float horizontalInput;
    private float verticalInput;
    public CharacterController playerController;

    void Update()
    {
        Direction();
    }

    void Direction()
    {
        //call horizontal & vertical inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move horizontal & vertical
        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;

        //mouse movement
        playerController.Move(move * speed * Time.deltaTime);
    }
}
