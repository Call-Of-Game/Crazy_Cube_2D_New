using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

	public Text TextCoin;
	public static int CoinAmount;
	// private int FirstCoins = 0;

	// void Awake()
	// {
	// 	FirstCoins = PlayerPrefs.GetInt("FirstCoins" , 0);
	// 	if(FirstCoins == 1)
	// 	{
	// 	Destroy (GameObject.FindWithTag("Coin"));
	// 	}
	// 	else
	// 	{
	// 	// Destroy (GameObject.FindWithTag("Coin"));
	// 	}

	// }


	void Start () {
		TextCoin = GetComponent<Text>();
		CoinAmount = PlayerPrefs.GetInt("Coins");
	}
	
	void Update () {
		//PlayerPrefs.SetInt("Coin", 1);
		TextCoin.text = CoinAmount.ToString();
		PlayerPrefs.SetInt("Coins", CoinAmount);
	}
}
