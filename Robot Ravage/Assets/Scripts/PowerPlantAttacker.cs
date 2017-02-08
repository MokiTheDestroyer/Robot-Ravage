using UnityEngine;
using System.Collections;

public class PowerPlantAttacker : MonoBehaviour {

	private GameObject smokeParent;
	public GameObject electricity;

	// Use this for initialization
	void Start () {
		smokeParent = GameObject.Find ("Particles");
		
		if(!smokeParent){
			smokeParent = new GameObject("Particles");
		}
	}
	
	public void Electricity(){
		GameObject smokePuff = Instantiate(electricity, transform.position, Quaternion.identity) as GameObject;
		smokePuff.transform.parent = smokeParent.transform;
	}
	
	
}
