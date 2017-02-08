using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {


	private GameObject smokeParent;
	public GameObject smoke;
	
	public float health = 100f;
	
	
	void Start () {
		smokeParent = GameObject.Find ("Particles");
		
		if(!smokeParent){
			smokeParent = new GameObject("Particles");
		}
	}
	
	
	public void DealDamage(float damage){
		health -= damage;
		if(health <= 0){
			PuffSmoke();
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
