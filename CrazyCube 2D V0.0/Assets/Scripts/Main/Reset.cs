using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Reset : EventTrigger {

	public override void OnPointerEnter(PointerEventData data){

		FindObjectOfType<ResetScript>().ResetGame();
	}
}
