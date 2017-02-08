using UnityEngine;
using System.Collections;

public class ProjectileExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Foreground";
		Destroy(gameObject, 3f);
		
	}
	
}
