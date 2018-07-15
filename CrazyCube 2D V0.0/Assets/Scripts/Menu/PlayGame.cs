using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayGame : EventTrigger {

	 public override void OnPointerEnter(PointerEventData data)
    {
        FindObjectOfType<PlayGameScript>().PLAY();
    }

// 	void Update () 
// 	{
// 		  foreach(Touch t in Input.touches)
//         {
//             Ray ray = Camera.main.ScreenPointToRay(t.position);
//             RaycastHit hit;

//             if(Physics.Raycast(ray, out hit))
//             {
                
//                 switch(t.phase)
//                 {
//                 case TouchPhase.Began:
// 					if(hit.collider.gameObject.tag == "PlayGame")
// 					{
//                         SceneManager.LoadScene("Main");
//                     }
// 				break;
//                 case TouchPhase.Moved:
//                 case TouchPhase.Stationary:
// 				break;
//                 default:
// 				break;
// 				}
// }
// 	}
// }
}
