using UnityEngine;
using System.Collections;

public class FPSAim : MonoBehaviour {
    float mouseX;
    float mouseY;
    public bool InvertedMouse;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
	}
}
