using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public static MusicManager instance = null;
	private AudioSource audioSource;
	
	void Awake(){
		audioSource = GetComponent<AudioSource>();
		if(instance !=  null){
			Destroy(gameObject);
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
}
