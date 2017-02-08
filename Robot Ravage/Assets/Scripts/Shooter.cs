using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, gun;
	private GameObject projectileParent;

	
	void Start(){
	
		projectileParent = GameObject.Find ("Projectiles");
		
		if(!projectileParent){
			projectileParent = new GameObject("Projectiles");
		}	
	}
	
	
	
	public void Fire(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position;
		
	}
}
