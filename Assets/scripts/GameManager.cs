using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	bool restart = false;
	public float respawnTime = 1f;
	public float loadTime = 1f;

	public void Respawn()
	{
		if (restart == false)
		{
			restart = true;
			Debug.Log("respawning");

			Invoke("ReloadLevel", respawnTime);
		}
	}

	void ReloadLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void NextLevel() //loads next level when level is complete (use Invoke to add a delay)
	{
		Invoke("LoadNextLevel", loadTime);
	}

	void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
