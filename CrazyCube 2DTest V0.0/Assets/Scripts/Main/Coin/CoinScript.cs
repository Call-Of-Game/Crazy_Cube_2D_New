using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// void Start()
	// {
	// 	coinTotal = PlayerPrefs.GetInt ("Coins");
	// }

	void OnTriggerEnter2D(Collider2D col)
	{
		int Coins = PlayerPrefs.GetInt("Coins");
		ScoreTextScript.CoinAmount +=1;
		Destroy(gameObject);
	}
}
