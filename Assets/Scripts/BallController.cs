using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float moveSpeed = 952f;
	
	// Update is called once per frame
	void Update () {
        //creates Value for movement to apply force
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //converting movement values into a vector to apply force to object
        Vector3 force = new Vector3(xMove, 0f, zMove);
        GetComponent<Rigidbody>().AddForce(force);
	}
}
