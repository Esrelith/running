using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		Invoke ("ExitGame", 3f);
	}

	private void ExitGame()
	{
		Debug.Log ("exiting");
		Application.Quit ();
	}
		
}
