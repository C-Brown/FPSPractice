using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

    public float radius = 5;
    public float power = 10;
    public float explosiveLift = 1;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, 3);

	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {
        Vector3 rocketOrigin = transform.position;
        Collider[] colliders = Physics.OverlapSphere(rocketOrigin, radius);

        foreach(Collider hit in colliders) {
            if (hit.GetComponent<Rigidbody>())
            {
                hit.GetComponent<Rigidbody>().AddExplosionForce(power, rocketOrigin, explosiveLift);
                Destroy(gameObject);
            }
        }
	}
}
