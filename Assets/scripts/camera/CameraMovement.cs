using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform trackObject;
	public Vector3 cameraOffset;

	public float lowerLimit = 0f;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = trackObject.position + cameraOffset;
		transform.LookAt(trackObject.position);

		if (transform.position.y <= lowerLimit)
		{
			transform.position = new Vector3(transform.position.x, lowerLimit, transform.position.z);
			transform.LookAt(trackObject.position);
			Debug.Log("lowerlimit reached");
		}
	}
}
