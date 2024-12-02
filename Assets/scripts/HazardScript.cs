using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Called when the object this script is attached to collides with another object.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))  // Checks if the colliding object has the tag "Player".
        {
            player.transform.position=startPoint.transform.position; // Moves the player to the position of the startPoint GameObject.
        }
    }
}
