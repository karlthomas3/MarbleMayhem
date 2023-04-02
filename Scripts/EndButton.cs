using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // if triggered by player
        {
            gameManager.CompleteLevel(); //turn on the level complete text
            gameManager.Invoke("NextScene", 2f); //jump to next level after short wait
        }
    }
}
