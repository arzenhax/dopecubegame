
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
   
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        //this says if the cube collides with something that has the tag "Obstacle",
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // this will turn off the movement
            movement.enabled = false;
            // this will show text in the console
            Debug.Log("You hit something!");

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
