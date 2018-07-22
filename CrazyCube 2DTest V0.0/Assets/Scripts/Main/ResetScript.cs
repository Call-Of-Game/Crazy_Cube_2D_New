using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour {

	public GameObject PausePanel;

	public void ResetGame()
	{
		PausePanel.SetActive(false);
		 SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1f;
	}
}
