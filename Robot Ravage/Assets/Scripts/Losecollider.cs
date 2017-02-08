using UnityEngine;
using System.Collections;

public class Losecollider : MonoBehaviour {

	private GameObject loseLabel;

	private NewLevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<NewLevelManager>();
		loseLabel = GameObject.Find("YouLose");
		loseLabel.SetActive(false);
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.GetComponent<Attacker>()){
			DestroyAllTaggedObjects();
			loseLabel.SetActive(true);
			Invoke("LoseScene", 5f);
		}
	}
	
	void DestroyAllTaggedObjects(){
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag("destroyOnLose");
		foreach(GameObject taggedObject in taggedObjectArray){
			Health health = taggedObject.gameObject.GetComponent<Health>();
			health.DealDamage(2000f);	
		}
	}
	
	
	void LoseScene(){
		levelManager.LoadLevel("LoseScreen");
	}
}
