using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScript : MonoBehaviour {

	public bool paused;
	public GameObject PausePanel;

	void Start()
	{
		paused = false;
	}

	public void ResumeGame()
	{
		paused = !paused;

		if(!paused)
		{
			
			Time.timeScale = 1f;
			//AudioListener.pause = true;
			PausePanel.SetActive(false);
			
		}

	}
}
