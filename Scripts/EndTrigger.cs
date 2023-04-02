using UnityEngine;

public class EndTrigger : MonoBehaviour
{
  void OnTriggerEnter(Collider other){

    if (other.gameObject.tag == "Player") {
        FindObjectOfType<GameManager>().HitWater();
    }

    if (other.gameObject.tag == "Enemy") {
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        Destroy(other.gameObject);
    }
  }
}
