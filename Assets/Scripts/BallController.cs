using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 100f; //how quickly the ball moves laterally
    public float jumpSpeed = 1000f;

    void Update()
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y / 2);

        //check for keypress and calculate movement speed
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime * Convert.ToInt32(isGrounded);
        
        Vector3 force = new Vector3(xMove, 0f, zMove); //create force vector and apply horizontal movement

        if (Input.GetButtonDown("Jump") && isGrounded) //Applies jump speed to the force vector if 
        {
            force.y = jumpSpeed * Time.deltaTime;
        }

        GetComponent<Rigidbody>().AddForce(force);
    }
}