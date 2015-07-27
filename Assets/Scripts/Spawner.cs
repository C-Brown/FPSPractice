using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] names = new string[] { "stubbs", "rob", "white" };

        for (int i = 0; i < names.Length; i++)
        {
            Zombie z = new Zombie(names[i], Random.Range(10, 15));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
