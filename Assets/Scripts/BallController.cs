using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 100f; //how quickly the ball moves laterally
    public float jumpSpeed = 1000f; //the upward impulse when the player jumps
    private bool isGrounded;

    public void OnCollisionEnter()
    {
        isGrounded = true;
    }

    public void OnCollisionExit()
    {
        isGrounded = false;
    }

    void Update() //movement specific
    {
        //check for keypress and calculate movement speed.
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        
        Vector3 force = new Vector3(xMove, 0f, zMove); //creates force vector for lateral movement

        if (Input.GetButtonDown("Jump") && isGrounded) //Applies jump speed to the force vector if jump button pressed and ball is grounded
        {
            force.y = jumpSpeed * Time.deltaTime;
        }

        GetComponent<Rigidbody>().AddForce(force); //adds all of the forces to the physics calculation
    }
}