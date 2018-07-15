using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resume : EventTrigger {

	public override void OnPointerEnter(PointerEventData data){

		FindObjectOfType<ResumeScript>().ResumeGame();
	}
}
