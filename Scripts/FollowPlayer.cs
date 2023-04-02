
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;// get the players location
    public Vector3 offset; // get the offset to move the camera to

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // move the camera to the offset every update
    }
}
