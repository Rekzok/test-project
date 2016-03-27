using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class KillPlane : MonoBehaviour {

    // This script sets a position on the y-axis at which the (player) object 
    // is considered "dead" and the level is restarted

    public float killPlane = -30f;

	void Update () {
	    if (transform.position.y <= killPlane)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
