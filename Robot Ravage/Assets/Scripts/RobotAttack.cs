using UnityEngine;
using System.Collections;

public class RobotAttack : MonoBehaviour {

	private Animator anim;
	private Attacker attacker;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	
	
	void OnTriggerEnter2D(Collider2D col){
		
		
		GameObject obj = col.gameObject;
		
		if(obj.GetComponent<Defender>() | obj.GetComponent<PowerPlantDefender>()){
			anim.SetBool ("isIdle", true);
			attacker.Attack(obj);
		}
		
		
		
	}
}
