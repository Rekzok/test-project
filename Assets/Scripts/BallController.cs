using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 100f; //how quickly the ball moves laterally
    public float jumpSpeed = 1000f; //the upward impulse when the player jumps

    void Update() //movement specific
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y / 2); //checks if ball is touching the ground

        //check for keypress and calculate movement speed; ball cannot change direction if in the air.
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        
        Vector3 force = new Vector3(xMove, 0f, zMove); //creates force vector for horizontal movement

        if (Input.GetButtonDown("Jump") && isGrounded) //Applies jump speed to the force vector if jump button pressed and ball is grounded
        {
            force.y = jumpSpeed * Time.deltaTime;
        }

        GetComponent<Rigidbody>().AddForce(force); //adds all of the forces to the physics calculation
    }
}