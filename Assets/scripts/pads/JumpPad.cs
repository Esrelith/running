using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {

	public float jumpForce = 10f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Player")
		{
			collision.collider.GetComponent<Rigidbody>().velocity = new Vector3(collision.collider.GetComponent<Rigidbody>().velocity.x, jumpForce, collision.collider.GetComponent<Rigidbody>().velocity.z);
		}
	}
}
