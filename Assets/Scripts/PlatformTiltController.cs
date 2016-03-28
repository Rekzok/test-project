using UnityEngine;
using System.Collections;

public class PlatformTiltController : MonoBehaviour {

    private float xDirection; // Determines whether the rotation on the x-axis is positive or negative
    private float zDirection; // Determines whether the rotation on the z-axis is positive or negative

    private float xAngle;
    private float zAngle;

    private float xRand;
    private float zRand;

    public float rotationSpeed = 5f; //speed at which the platform tilts
    public float maxAngle = 20f; // The maximum the platform can be angled 

    public float reverseChance = 0.10f; // Precent chance that the direction of rotation will change

    void Start ()
    {
        //Gives the platform a random direction for initial rotation
        xDirection = Random.Range(0, 2) * 2 - 1;
        zDirection = Random.Range(0, 2) * 2 - 1;
        xRand = Random.value + Random.Range(1, 3);
        zRand = Random.value + Random.Range(1, 3);
    }
	
	void Update ()
    {
        //rotates the platform a certain amount each frame
        transform.Rotate(Vector3.right, xDirection * rotationSpeed * xRand * Time.deltaTime);
        xAngle += xDirection * rotationSpeed * xRand * Time.deltaTime;
        transform.Rotate(Vector3.forward, zDirection * rotationSpeed * zRand * Time.deltaTime);
        zAngle += zDirection * rotationSpeed * zRand * Time.deltaTime;

        //checks if platform has reached its maximum angle and reverses its direction if so
        if (xAngle >= maxAngle || xAngle <= -maxAngle)
        {
            xDirection = xDirection * -1;
            xRand = Random.value + Random.Range(1, 3);
        }
        if (zAngle >= maxAngle || zAngle <= -maxAngle)
        {
            zDirection = zDirection * -1;
            zRand = Random.value + Random.Range(1, 3);
        }
    }
}
