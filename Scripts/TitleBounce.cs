using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBounce : MonoBehaviour
{
    public Rigidbody rb; // current body
    public float bounce = 10; // bounce height
    private void OnCollisionEnter(Collision other) {
        rb.AddForce(0, bounce, 0, ForceMode.Impulse); // add upward force to body
    }
}
