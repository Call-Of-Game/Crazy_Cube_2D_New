using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pause :  EventTrigger {

	public override void OnPointerEnter(PointerEventData data){

		FindObjectOfType<PauseScript>().PauseGame();
	}
}
