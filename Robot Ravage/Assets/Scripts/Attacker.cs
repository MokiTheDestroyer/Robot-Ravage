using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Tooltip ("Average number of seconds between appearances")]
	public float seenEverySeconds;
	private Animator animator;
	private float currentSpeed;
	private GameObject currentTarget;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
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
