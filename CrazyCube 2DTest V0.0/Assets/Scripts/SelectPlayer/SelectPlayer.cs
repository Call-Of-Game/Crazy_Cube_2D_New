using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectPlayer : MonoBehaviour 
{
	[SerializeField] private GameObject[] sprites;

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 world= Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(world, Vector2.zero, 1);
			if(hit.collider != null)
			{
				for(int i = 0; i < sprites.Length; i++)
				{
					if(hit.collider.gameObject == sprites[i])
					{
						LoadGame(i);
					}
				}
			}
		}
	}

	public void LoadGame(int selectedIndex)
	{
        PlayerPrefs.SetInt("CharacterSelected" , selectedIndex);
		SceneManager.LoadScene ("Menu");
	}
}
