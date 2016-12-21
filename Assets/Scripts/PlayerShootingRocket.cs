using UnityEngine;
using System.Collections;

public class PlayerShootingRocket : MonoBehaviour {

    public Rigidbody rocket;
    public float launchPower = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;

            clone = (Rigidbody)Instantiate(rocket, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * launchPower);
        }
	}
}
