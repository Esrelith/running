using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	bool restart = false;
	public float respawnTime = 1f;

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
}
