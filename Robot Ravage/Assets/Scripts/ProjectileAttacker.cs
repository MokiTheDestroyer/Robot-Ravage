using UnityEngine;
using System.Collections;

public class ProjectileAttacker : MonoBehaviour {

	private GameObject smokeParent;
	public GameObject smoke;
	public float speed;
	public float damage;
	
	// Use this for initialization
	void Start () {
		smokeParent = GameObject.Find ("Particles");
		
		if(!smokeParent){
			smokeParent = new GameObject("Particles");
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D col){
		Defender defender = col.gameObject.GetComponent<Defender>();
		Health health = col.gameObject.GetComponent<Health>();
		PowerPlantDefender powerPlant = col.gameObject.GetComponent<PowerPlantDefender>();
		
		if(defender && health){
			PuffSmoke();
			health.DealDamage(damage);
			Destroy(gameObject);
		}
		
		if(powerPlant && health){
			PuffSmoke();
			health.DealDamage(damage);
			Destroy(gameObject);
		}
	}
	
	void PuffSmoke(){
		GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
		smokePuff.transform.parent = smokeParent.transform;
	}
	
}
