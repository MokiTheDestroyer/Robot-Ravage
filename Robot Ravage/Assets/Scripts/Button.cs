using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;

	private Button[] buttonArray;
	public static GameObject selectedDefender;

	void Start(){
		buttonArray = GameObject.FindObjectsOfType<Button>();
		MakeButtonsBlack();
	}

	void OnMouseDown(){
		MakeButtonsBlack();	

	}
	
	void MakeButtonsBlack(){
		foreach(Button thisButton in buttonArray){
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		
		selectedDefender = defenderPrefab;
		GetComponent<SpriteRenderer>().color = Color.white;
	}
}
