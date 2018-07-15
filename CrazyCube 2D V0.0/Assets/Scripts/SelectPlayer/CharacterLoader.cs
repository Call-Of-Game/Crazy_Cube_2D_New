using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLoader : MonoBehaviour 
{
    [SerializeField] private GameObject[] characterList;

    private void Start()
    {
        var index = PlayerPrefs.GetInt("CharacterSelected");
		characterList = new GameObject[transform.childCount];
		for (int i=0 ; i <transform.childCount ; i++)
		{
			characterList[i] = transform.GetChild(i).gameObject;
            if(i == index)
            {
			       characterList[i].SetActive(true);
                   transform.parent.tag = characterList[i].tag;
            }
            else
            {
                characterList[i].SetActive(false);
            }
		}
    }
}