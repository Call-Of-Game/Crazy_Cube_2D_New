using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

	public Text TextCoin;
	public static int CoinAmount;

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
