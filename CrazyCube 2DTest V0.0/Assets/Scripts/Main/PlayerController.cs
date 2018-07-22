using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

  	// private Rigidbody2D PlayerRigidbody;
	// public float speed;
	// public float jumpSpeed;
	// public LayerMask groundLayer;
	// public Sprite RedSprite;
	// public Sprite WhiteSprite;
	// public Sprite BlueSprite;
	// public Vector3 respawnPoint;
	//public GameObject Finger;

	  void Start()
	   {
	// 	  PlayerRigidbody = GetComponent<Rigidbody2D>();
	// 	  respawnPoint = transform.position;
		  //Screen.orientation = ScreenOrientation.LandscapeLeft;
		  //distanceToGround = GetComponent<Collider2D>().bounds.extents.y;
	  }

	  void FixedUpdate()
	  {

		// float rotationSpeed =0f;

		// Vector2 myvel = PlayerRigidbody.velocity;
        // myvel.x = speed; 	
        // PlayerRigidbody.velocity = myvel; 

        // int fingerCount = 0;
        // foreach (Touch touch in Input.touches)
		//  {
        //     if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
        //         fingerCount++;
  
        //  }
        // if (fingerCount > 0 && IsGrounded())
        // {
        //     Vector2 jumpVector = PlayerRigidbody.velocity;
        //     jumpVector.y = jumpSpeed;
        //     PlayerRigidbody.velocity = jumpVector;
        //    PlayerRigidbody.AddTorque(Input.GetAxis ("Horizontal") * rotationSpeed);
        // }

		//  if (Input.GetKey("a")  && IsGrounded() )
		//  {
		// 	Vector2 jumpVector = PlayerRigidbody.velocity;
        //     jumpVector.y = jumpSpeed;
        //     PlayerRigidbody.velocity = jumpVector;
        //    PlayerRigidbody.AddTorque(Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime);
		   
		//  }
	
	//   }
	//     bool IsGrounded()
    // 	 {
   	//  	Vector2 position = transform.position;
    // 	Vector2 direction = Vector2.down;
    // 	float distance = 1.0f;
    
    // 	RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
    // 	if (hit.collider != null) 
	// 	 {
    //     return true;
    // 	 }
    
    //     return false;
	     
    //      }

    //      #region PlayerCollition

    // void OnTriggerEnter2D(Collider2D col)
    // {
	// 	#region Barkhord Be Mavane Gheir Hamrang
	// 	if(tag== "WhitePlayer")
	// 	{
	// 	if (col.gameObject.tag == "ObstacleRed" || col.gameObject.tag == "ObstacleBlue")
	// 	{
	// 		print("After Collision... ");
	// 		CameraShake.shakeAmount = 0.3f;
    //         CameraShake.shakeDuration = 0.3f;
	// 		//GetComponent<PlayerController>().enabled = false;
	// 		//Invoke("ResetGame",1f);
	// 		transform.position = respawnPoint;		
	// 	}
	// 	}

	// 	if(tag== "RedPlayer")
	// 	{
	// 	if (col.gameObject.tag == "ObstacleWhite" || col.gameObject.tag == "ObstacleBlue" )
	// 	{
	// 		print("After Collision... ");
	// 		CameraShake.shakeAmount = 0.3f;
    //         CameraShake.shakeDuration = 0.3f;
	// 		// GetComponent<PlayerController>().enabled = false;
	// 		// Invoke("ResetGame",1f);
	// 		transform.position = respawnPoint;
				
	// 	}
	// 	}


	// 	if(tag== "BluePlayer")
	// 	{
	// 	if (col.gameObject.tag == "ObstacleWhite" || col.gameObject.tag == "ObstacleRed" )
	// 	{
	// 		print("After Collision... ");
	// 		CameraShake.shakeAmount = 0.3f;
    //         CameraShake.shakeDuration = 0.3f;
	// 		// GetComponent<PlayerController>().enabled = false;
	// 		// Invoke("ResetGame",1f);
	// 		transform.position = respawnPoint;
				
	// 	}
	// 	}
    //    #endregion Barkhord Be Mavane Gheir Hamrang
		
	// 	#region Taghir Range Player
	// 	if(col.gameObject.tag == "ChangeColorRed")
	// 	{

	// 		this.gameObject.GetComponent<SpriteRenderer>().sprite = RedSprite;
	// 		tag ="RedPlayer";
			
	// 	}

	// 	if(col.gameObject.tag == "ChangeColorBlue")
	// 	{

	// 		this.gameObject.GetComponent<SpriteRenderer>().sprite = BlueSprite;
	// 		tag ="BluePlayer";
			
	// 	}
	// 	#endregion Taghir Range Player


	// 	 #region Reset
	// 	if(col.gameObject.tag == "Reset")
	// 	{
	// 	    int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
	// 		int maxLevelReach = PlayerPrefs.GetInt("Level", 1);
	// 		if (currentLevel ==maxLevelReach)
	// 		PlayerPrefs.SetInt("Level" , maxLevelReach + 1);
	// 		Invoke("ResetGame",1f);

	// 	}
	// 	#endregion Reset

	// 	#region CheckPoint

	// 	if(col.tag == "CheckPoint")
	// 	{
	// 		respawnPoint = col.transform.position;
	// 	}

	// 	#endregion CheckPoint
	// }
	// #endregion PlayerCollition

	// public void ResetGame()
	// {
	// 	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	// }

}
}



