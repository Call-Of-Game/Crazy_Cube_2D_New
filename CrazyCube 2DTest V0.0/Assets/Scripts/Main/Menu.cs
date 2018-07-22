using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menu :EventTrigger {

	public override void OnPointerEnter(PointerEventData data){

		FindObjectOfType<MenuScript>().MenuGame();
	}
}
