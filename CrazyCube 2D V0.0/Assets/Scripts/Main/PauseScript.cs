using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	public bool paused;
	public GameObject PausePanel;

	void Start()
	{
		paused = false;
		
	}

	public void PauseGame()
	{
		PausePanel.SetActive(true);
		paused = !paused;

		if(paused)
		{
			
			Time.timeScale = 0f;
			//AudioListener.pause = true;
			
		}
		// else
		// {
			
		// 	Time.timeScale = 1f;
		// 	//AudioListener.pause = false;

		// }
	}
}
