using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	bool restart = false;
	public float respawnTime = 1f;
	public float loadTime = 1f;

	public void Respawn() //respawns player
	{
		if (restart == false)
		{
			restart = true;
			Debug.Log("respawning");

			Invoke("ReloadLevel", respawnTime);
		}
	}

	void ReloadLevel() //reloads scene after player death
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void SelectedLevel() //loads next level when level is complete (use Invoke to add a delay)
	{
		Invoke("LoadSelectedLevel", loadTime);
	}

	void LoadSelectedLevel() //loads the selected level from the global level select
	{
        if (LevelSelect.SelectedLevel != -1)
        {
            SceneManager.LoadScene(LevelSelect.SelectedLevel);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}
}
