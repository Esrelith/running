using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody player;
	private float moveSpeed = 42.5f;
	public float jumpSpeed = 10000f;

	public float voidHeight;
	
	public Vector3 boostMoveSpeed = new Vector3 (20,0,20);
	Vector3 movement = Vector3.zero;


	public bool isGrounded { get; set; }

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
