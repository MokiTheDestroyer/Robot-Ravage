using UnityEngine;
using System.Collections;

public class HealthAttackers : MonoBehaviour {

	public int scoreWorth = 100;
	private GameObject smokeParent;
	public GameObject smoke;
	private Score score;
	public float health = 100f;
	
	
	void Start () {
		score = FindObjectOfType<Score>();
		smokeParent = GameObject.Find ("Particles");
		
		if(!smokeParent){
			smokeParent = new GameObject("Particles");
		}
	}
	
	
	public void DealDamage(float damage){
		health -= damage;
		if(health <= 0){
			PuffSmoke();
			score.AddScore(scoreWorth);
			DestroyObject();
		}
	}
	
	public void DestroyObject(){
		Destroy(gameObject);
	}
	
	
	void PuffSmoke(){
		GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
		smokePuff.transform.parent = smokeParent.transform;
	}
}
