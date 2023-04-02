using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTile : MonoBehaviour
{
    public float jump = 5; // jump force
    Rigidbody rb; // current body
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player" | other.gameObject.tag == "Enemy") // if contact with player
        {
            rb = other.gameObject.GetComponent<Rigidbody>(); // access the player rigidbody
            rb.AddForce(0, jump, 0, ForceMode.Impulse); // and add upward force
        } 
    }
}
