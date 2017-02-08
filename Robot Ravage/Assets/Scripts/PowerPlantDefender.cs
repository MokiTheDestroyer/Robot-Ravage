using UnityEngine;
using System.Collections;

public class PowerPlantDefender : MonoBehaviour {

	public GameObject electricity;

	private GameObject smokeParent;
	private PowerDisplay powerDisplay;

	void Start(){
		smokeParent = GameObject.Find ("Particles");
		
		if(!smokeParent){
			smokeParent = new GameObject("Particles");
		}
	
		powerDisplay = GameObject.FindObjectOfType<PowerDisplay>();
	}

	public void AddPower(int amount){
		powerDisplay.AddPower(amount);
	}
	
	public void Electricity(){
		GameObject smokePuff = Instantiate(electricity, transform.position, Quaternion.identity) as GameObject;
		smokePuff.transform.parent = smokeParent.transform;
	}
}
