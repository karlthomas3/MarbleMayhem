using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody enemyRB; // current body
    public GameObject player; // player to attack

    public float attackDistance = 10f; // how close you have to get before getting attacked
    public float attackSpeed = 5f; // maximum force to attack with
    float currentDistance; // how far away is the player
    Vector3 aim;// vector for aiming at enemy
    private bool attacking = false; // have we started attacking the player
    public float attackWait = 2f; // maximum wait between attacks

    // Update is called once per frame
    void Update()
    {
        currentDistance = Vector3.Distance(player.gameObject.transform.position, transform.position); // check how far away the player is
        // Debug.Log(currentDistance);
        if (currentDistance < attackDistance && !attacking) {
            StartCoroutine(AttackPlayer());
            attacking = true;
        }
    }

    IEnumerator AttackPlayer() {

        while (true) 
        {
            aim = player.gameObject.transform.position - transform.position; // figure out where the player is
            aim.Normalize();
            enemyRB.AddForce(aim * Random.Range(1, attackSpeed), ForceMode.Impulse);// move towards the player
            yield return new WaitForSeconds(Random.Range(0.1f,attackWait)); // wait and do it again
            
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Hit");
        }
    }
}
