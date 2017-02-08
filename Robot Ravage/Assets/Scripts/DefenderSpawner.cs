using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {



	public Camera myCamera;
	private GameObject defenderParent;
	private PowerDisplay powerDisplay;
	
	void Start(){
		defenderParent = GameObject.Find("Defenders");
		powerDisplay = GameObject.FindObjectOfType<PowerDisplay>();
		
		if(!defenderParent){
			defenderParent = new GameObject("Defenders");
		}
	}
	
	void OnMouseDown(){
		
		GameObject defender = Button.selectedDefender;
		Vector2 rawPos = CalculateWorldPointOfMouseClick();
		Vector2 roundedPos = SnapToGrid(rawPos);
		
		int defenderCost = defender.GetComponent<Defender>().powerCost;
		
		print (roundedPos);
		
		if(powerDisplay.UsePower(defenderCost) == PowerDisplay.Status.SUCCESS){
			SpawnDefender (roundedPos, defender);
		}else{
			Debug.Log("Insufficient power to spawn");
		}
	}

	void SpawnDefender (Vector2 roundedPos, GameObject defender)
	{
		Quaternion zeroRotation = Quaternion.identity;
		if (defender) {
			GameObject newDef = Instantiate (defender, roundedPos, zeroRotation) as GameObject;
			newDef.transform.parent = defenderParent.transform;
		}
	}
	
	Vector2 SnapToGrid(Vector2 rawWorldPos){
		float newX = Mathf.RoundToInt(rawWorldPos.x);
		float newY = Mathf.RoundToInt(rawWorldPos.y); 
		
		return new Vector2 (newX, newY);	
	}
	
	Vector2 CalculateWorldPointOfMouseClick(){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		
		float distanceFromCamera = 10f;
		Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
		Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);
		
		return worldPos;
	}
}
