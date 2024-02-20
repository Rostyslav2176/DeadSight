using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    private Vector3 crouchScale = new Vector3(1, 0.5f, 1);
    private Vector3 playerScale = new Vector3(1, 1f, 1);

    void Update()
    {
        //start crouching
        if (Input.GetKeyDown(KeyCode.LeftControl))

        {
            transform.localScale = crouchScale;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z); //shrink character
        }

        //stop crouching
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = playerScale;
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z); //return character to normal size
        }
    }
}
