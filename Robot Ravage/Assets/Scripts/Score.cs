using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	private Text scoreText;
	public static int score;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		UpdateDisplay();
	}
	
	public void AddScore(int amount){
		score += amount;
		UpdateDisplay();
	}
	
	private void UpdateDisplay(){
		scoreText.text = score.ToString();
	}
}
