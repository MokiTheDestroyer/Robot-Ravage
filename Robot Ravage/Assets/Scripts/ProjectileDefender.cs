using UnityEngine;
using System.Collections;

public class ProjectileDefender : MonoBehaviour {

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
		Attacker attacker = col.gameObject.GetComponent<Attacker>();
		HealthAttackers health  = col.gameObject.GetComponent<HealthAttackers>();
		PowerPlantAttacker powerPlant = col.gameObject.GetComponent<PowerPlantAttacker>();
		
		
		if(attacker && health){
			health.DealDamage(damage);
			PuffSmoke();
			Destroy(gameObject);
		}
		
		if(powerPlant && health){
			health.DealDamage(damage);
			PuffSmoke();
			Destroy(gameObject);
		}
	}

	void PuffSmoke(){
		GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
		smokePuff.transform.parent = smokeParent.transform;
	}
}
