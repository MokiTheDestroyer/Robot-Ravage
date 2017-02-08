using UnityEngine;
using System.Collections;

public class ResetScoreAndPower : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {
		
		Score.score = 0;
		PowerDisplay.power = 500;
	}
	
	
}
