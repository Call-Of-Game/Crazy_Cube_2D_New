using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	[SerializeField] private float CurrentAmount;
	[SerializeField] private float Speed;

	// void Start()
	// {
	// 	LoadingBar.GetComponent<Image>().fillAmount = 0;
	// }

	void Update()
	{
		if(CurrentAmount < 100)
		{
			CurrentAmount += Speed * Time.deltaTime;
			TextIndicator.GetComponent<Text>().text = ((int)CurrentAmount).ToString()+"";
			TextLoading.gameObject.SetActive(true);

		}
		else{
			TextLoading.gameObject.SetActive(false);
			TextIndicator.GetComponent<Text>().text = "Win!";
		}

		LoadingBar.GetComponent<Image>().fillAmount = CurrentAmount / 100;
	}
}
