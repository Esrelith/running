using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{

	public Transform player;
	public float lerpSpeed;

	// Use this for initialization
	void Start()
	{
		transform.position = player.position;
	}

	//Update is called once per frame
	void Update()
	{
		transform.position = Vector3.Lerp(player.position, transform.position, lerpSpeed);
	}
}
