using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	public int powerCost = 100;

	//private PowerDisplay powerDisplay;
	private Animator animator;
	private float currentSpeed;
	private GameObject currentTarget;
	
	// Use this for initialization
	void Start () {
		//powerDisplay = GameObject.FindObjectOfType<PowerDisplay>();
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
		if(!currentTarget){
			animator.SetBool("isIdle", false);
		}
	}
	
	
	
	public void SetSpeed(float speed){
		currentSpeed = speed;
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
	
}