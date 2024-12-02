using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=10f;
    private float Move;
    public float Jump=600;
    public bool isJumping;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();  // Gets the Rigidbody2D component attached to the object this script is on.
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");// Gets horizontal input (e.g., A/D keys or Left/Right arrow keys).
        rb.velocity= new Vector2(speed*Move, rb.velocity.y);
        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump)); // Checks if the Jump button (default is Space) is pressed and if the player is not currently jumping.
            Debug.Log("Jump"); // Logs a message to the console for debugging.
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground")) // Checks if the object collided with has the "ground" tag.
        { 
            isJumping = false;  // Sets isJumping to false, allowing the player to jump again.
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground")) // Checks if the object that was exited has the "ground" tag.
        {
            isJumping = true; // Sets isJumping to true, preventing mid-air jumps.
        }
    }
    
}
