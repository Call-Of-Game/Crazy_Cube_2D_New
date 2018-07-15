using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

     private bool dirRight = true;
     public float speed = 2.0f;
	//  public GameObject GearOne;
	//  public GameObject GearTwo;
 
     void Update () {
		//  GearOne.transform.Rotate(0,0,5);
		//  GearTwo.transform.Rotate(0,0,-5);

         if (dirRight)
             transform.Translate (Vector2.right * speed * Time.deltaTime);
         else
             transform.Translate (-Vector2.right * speed * Time.deltaTime);
         
         if(transform.position.x >= 4.0f) {
             dirRight = false;
         }
         
         if(transform.position.x <= -4) {
             dirRight = true;
         }
}
}
