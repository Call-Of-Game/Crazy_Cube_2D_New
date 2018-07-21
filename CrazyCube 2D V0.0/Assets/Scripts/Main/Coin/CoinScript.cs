using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// public GameObject One;
	// public GameObject Two;
	// //public GameObject Three;
	
	// private int CoinOne = 0;
	// private int CoinTwo = 0;
	// //private int CoinThree = 0;

	// void Awake()
	// {
	// 	CoinOne = PlayerPrefs.GetInt("Coin1" , 0);

	// 	if(CoinOne == 0)
	// 	{

	// 		One.SetActive(true);
			
	// 	}
	// 	else
	// 	{
	// 		One.SetActive(false);
	// 	}

	// 	CoinTwo = PlayerPrefs.GetInt("Coin2" , 0);

	// 	if(CoinTwo == 0)
	// 	{

	// 		Two.SetActive(true);
			
	// 	}
	// 	else
	// 	{
	// 		Two.SetActive(false);

	// 	}

		// CoinThree = PlayerPrefs.GetInt("Coin3" , 0);

		// if(CoinThree == 0)
		// {

		// 	Three.SetActive(true);
			
		// }
		// else
		// {
		// 	Three.SetActive(false);
		// }
	// }

	void OnTriggerEnter2D(Collider2D col)
	{
		int Coins = PlayerPrefs.GetInt("Coins");
		ScoreTextScript.CoinAmount +=1;
		Destroy(gameObject);
	}
}
