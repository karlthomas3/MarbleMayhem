using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Force = 30f;
    public float Jump = 2f;

    // Fixed update is better for physics
    void Update()
    {
        // add force in direction keys pressed
        if (Input.GetKey("up")) {
            rb.AddForce(0,0,Force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("down")) {
            rb.AddForce(0,0,-Force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("right")) {
            rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left")) {
            rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
