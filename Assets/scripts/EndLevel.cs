using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

	public GameManager gamemanager;

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Level Complete");
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		gamemanager.NextLevel();
	}
}
