using UnityEngine;
using System.Collections;

public class WinCollider : MonoBehaviour {

	
	
	
	private GameObject winLabel;
	
	private Score score;
	private NewLevelManager levelManager;
	private PowerDisplay powerDisplay;

	void Start(){

		winLabel = GameObject.Find("YouWon");
		winLabel.SetActive(false);
		score = FindObjectOfType<Score>();
		powerDisplay = FindObjectOfType<PowerDisplay>();
		levelManager = FindObjectOfType<NewLevelManager>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.GetComponent<Defender>()){
			HandleWinCondition ();
			
		}
	}

	void HandleWinCondition (){
		DestroyAllTaggedObjects();
		winLabel.SetActive (true);
		Invoke ("NextScene", 5f);
		score.AddScore (1000);
		powerDisplay.AddPower (500);
		gameObject.SetActive (false);
	}	
	
	void DestroyAllTaggedObjects(){
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag("destroyOnWin");
		foreach(GameObject taggedObject in taggedObjectArray){
			HealthAttackers health = taggedObject.gameObject.GetComponent<HealthAttackers>();
			health.DealDamage(2000f);	
		}
	}
	
	void NextScene(){
		levelManager.LoadNextLevel();
	}
	
}
