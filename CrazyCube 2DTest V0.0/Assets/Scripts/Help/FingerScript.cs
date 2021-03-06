﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FingerScript : MonoBehaviour {

	public Sprite RedSprite;
	public Sprite WhiteSprite;
	public Sprite BlueSprite;
	//public Vector3 respawnPoint;
	bool gronded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public float JumpForce = 700f;
	public float topSpeed = 10f;
	public float fallingBoost = 1;
	public LayerMask whatIsGround;
	private Rigidbody2D PlayerRigidbody;
	public float speed;
	private float MoveInput;
	public GameObject Finger;
	public Transform respawn;
	public Camera mainCamera;	
	//public float Roatation;

	  void Start()
	  {
		  PlayerRigidbody = GetComponent<Rigidbody2D>();
	  }
	  
	void Update()
	{ 
		Vector2 myvel = PlayerRigidbody.velocity;
        myvel.x = speed; 	
        PlayerRigidbody.velocity = myvel; 
		gronded = Physics2D.OverlapCircle(groundCheck.position,groundRadius , whatIsGround);

		if(gronded && Input.GetKeyDown(KeyCode.Space) ) 
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,JumpForce));
			PlayerRigidbody.AddTorque(-90);
		}

		int fingerCount = 0;
        foreach (Touch touch in Input.touches)
		 {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                fingerCount++;
  
         }
        if (fingerCount > 0 && gronded)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,JumpForce));
		}


		if(myvel.y < 0 )
		{
			PlayerRigidbody.AddForce(Vector2.down * fallingBoost);
		}

		if(Finger.gameObject == true && Input.GetKeyDown(KeyCode.Space) || Finger.gameObject == true && fingerCount > 0)
		{
			Finger.SetActive(false);
			Time.timeScale = 1f;	
		}
       
	}
	  
    void OnTriggerEnter2D(Collider2D col)
    {
		if(tag== "WhitePlayer")
		{
		if (col.gameObject.tag == "ObstacleRed" || col.gameObject.tag == "ObstacleBlue")
		{
			print("After Collision... ");
			CameraShake.shakeAmount = 0.3f;
            CameraShake.shakeDuration = 0.3f;
			//GetComponent<PlayerController>().enabled = false;
			Invoke("ResetGame",1f);
			//transform.position = respawnPoint;		
		}
		}

		if(tag== "RedPlayer")
		{
		if (col.gameObject.tag == "ObstacleWhite" || col.gameObject.tag == "ObstacleBlue" )
		{
			print("After Collision... ");
			CameraShake.shakeAmount = 0.3f;
            CameraShake.shakeDuration = 0.3f;
			// GetComponent<PlayerController>().enabled = false;
			Invoke("ResetGame",1f);
			//transform.position = respawnPoint;	
				
		}
		}

		if(tag== "BluePlayer")
		{
		if (col.gameObject.tag == "ObstacleWhite" || col.gameObject.tag == "ObstacleRed" )
		{
			print("After Collision... ");
			CameraShake.shakeAmount = 0.3f;
            CameraShake.shakeDuration = 0.3f;
			// GetComponent<PlayerController>().enabled = false;
			 Invoke("ResetGame",1f);
			//transform.position = respawnPoint;
				
		}
		}

		if(col.gameObject.tag == "ChangeColorRed")
		{

			this.gameObject.GetComponent<SpriteRenderer>().sprite = RedSprite;
			tag ="RedPlayer";
			
		}

		if(col.gameObject.tag == "ChangeColorBlue")
		{

			this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueSprite;
			tag ="BluePlayer";
			
		}

		if(col.gameObject.tag == "Reset")
		{
		    int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
			int maxLevelReach = PlayerPrefs.GetInt("Level", 1);
			if (currentLevel ==maxLevelReach)
			PlayerPrefs.SetInt("Level" , maxLevelReach + 1);
			//PlayerPrefs.SetInt("FirstCoins" , 1);
			Invoke("ResetGame",1f);

		}

		// if(col.tag == "CheckPoint")
		// {
		// 	respawnPoint = col.transform.position;
		// }

		if(col.gameObject.tag == "Finger")
		{
			//PlayerPrefs.SetInt("Finger" , 1);	
			Finger.SetActive(true);
			Time.timeScale = 0f;
		}

		if(col.gameObject.tag == "AutoJump")
		{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0,JumpForce * 1.5f));
		}

		if(col.gameObject.tag == "Coin")
			{
			 PlayerPrefs.SetInt("Coin1" , 1);
			}
	}


	public void ResetGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex );	
		//SceneManager.LoadScene("Levels");
	}
}
