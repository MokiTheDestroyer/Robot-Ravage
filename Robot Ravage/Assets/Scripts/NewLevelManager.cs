using UnityEngine;
using System.Collections;

public class NewLevelManager : MonoBehaviour {

	private AdsManager ads;
	public float autoLoadNextLevelAfter;

	void Start(){
		ads = GameObject.FindObjectOfType<AdsManager>();
		
		if(autoLoadNextLevelAfter <= 0f){
			Debug.Log("Auto load disabled");
		}else{
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
		
	}
	
	public void AdsLoadLevel(string name){
		ads.ShowAd();
		Application.LoadLevel(name);
	}
	
	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	
	
	public void AdsLoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
		ads.ShowRewardedAd();
		
	}
	
	
	
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}


