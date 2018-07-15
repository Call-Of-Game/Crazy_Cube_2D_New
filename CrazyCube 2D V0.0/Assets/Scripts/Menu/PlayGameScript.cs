using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 

public class PlayGameScript : MonoBehaviour {

	void Start()
	{
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	public void PLAY()
	{
		SceneManager.LoadScene("Levels");
		Time.timeScale = 1f;
	}
}
