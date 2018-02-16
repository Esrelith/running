using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

	public GameManager gamemanager;
    public int levelSelect = -1;

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Level Complete");
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
        if (levelSelect != -1)
        {
            gamemanager.StartCoroutine(gamemanager.SelectedLevel(levelSelect));
        }
        else
        {
            gamemanager.NextLevel();
        }
	}
}
