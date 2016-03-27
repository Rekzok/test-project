using UnityEngine;
using System.Collections;

public class PlatformTiltController : MonoBehaviour {

    float xDirection = 1f; // Determines whether the rotation on the x-axis is positive or negative
    float zDirection = 1f; // Determines whether the rotation on the z-axis is positive or negative
    float rotationSpeed = 5; //speed at which the platform tilts
    float maxAngle = 40f; // The maximum the platform can be angled 
    float reverseChance = 0.10f; // Precent chance that the direction of rotation will change

    // Use this for initialization
    void Start ()
    {
        xDirection = Random.Range(0, 2) * 2 - 1;
        zDirection = Random.Range(0, 2) * 2 - 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.forward, xDirection * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, zDirection * rotationSpeed * Time.deltaTime);

        /*if (transform.rotation.x >= maxAngle || transform.rotation.x <= -maxAngle)
        {
            xDirection = xDirection * -1;
        }

        if (transform.rotation.z >= maxAngle || transform.rotation.z <= -maxAngle)
        {
            zDirection = zDirection * -1;
        }*/
    }
}
