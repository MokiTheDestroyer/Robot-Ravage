using UnityEngine;
using System.Collections;

public class RobotDefender : MonoBehaviour {

	private Animator anim;
	private Defender attacker;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Defender>();
	}
	
	// Update is called once per frame
	
	
	void OnTriggerEnter2D(Collider2D col){
		
		
		GameObject obj = col.gameObject;
		
		if(obj.GetComponent<Attacker>() | obj.GetComponent<PowerPlantAttacker>()){
			anim.SetBool ("isIdle", true);
			attacker.Attack(obj);
		}
		
		
	}
}
