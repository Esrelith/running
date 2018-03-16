using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

    public GameManager gamemanager;
    public int levelSelect = -1; //-1 loads the next level anything else loads the selected level
    
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Level Complete");
		AudioSource audio = GetComponent<AudioSource>(); //audio cue for level end
		audio.Play();

        LevelSelect.SelectedLevel = levelSelect; //sets global level select
        gamemanager.SelectedLevel(); //calls the level select from game manager
	}
}
