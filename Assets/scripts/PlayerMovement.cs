using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody player;
	private float moveSpeed = 42.5f;
	public float voidHeight;
	Vector3 movement = Vector3.zero;

	

	// Use this for initialization
	void Start ()
	{
		player = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (player.position.y <= voidHeight)
		{
			FindObjectOfType<GameManager>().Respawn();

			if (transform.localScale != Vector3.zero)
			{
				transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
			}
		}
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		movement.x = Input.GetAxis("Horizontal") * moveSpeed;
		movement.z = Input.GetAxis("Vertical") * moveSpeed;

		player.AddForce(movement);
	}
}
