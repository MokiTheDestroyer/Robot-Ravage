using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	private NewLevelManager levelManager;

	void Start(){
		levelManager = GameObject.FindObjectOfType<NewLevelManager>();	
	}
	
	void OnMouseDown(){
		levelManager.AdsLoadLevel("StartScreen");
	}
}
