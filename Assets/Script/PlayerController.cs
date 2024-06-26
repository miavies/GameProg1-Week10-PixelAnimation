using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is walking right
        if (Input.GetKey(KeyCode.D))
        {
            // Check if LeftShift is held down to run
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("RunRight", true);
            }
            else
            {
                playerAnim.SetBool("RunRight", false);
                playerAnim.SetBool("WalkRight", true);
            }
        }
        else
        {
            playerAnim.SetBool("WalkRight", false);
            playerAnim.SetBool("RunRight", false);
        }

        // Reset running animation when LeftShift is released
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnim.SetBool("RunRight", false);
        }
    }
}
