using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour {

	public enum Status{SUCCESS, FAILURE};

	private Text powerText;
	public static int power;

	void Start(){
		powerText = GetComponent<Text>();
		UpdateDisplay();
	}

	void Update(){
		UpdateDisplay();
	}

	public void AddPower(int amount){
		power += amount;
		UpdateDisplay();
	}
	
	public void BonusAddPower(){
		power += 200;
	}
	
	public Status UsePower(int amount){
		if(power >= amount){
			power -= amount;
			UpdateDisplay();
			return Status.SUCCESS;
		}
		
		return Status.FAILURE;
		
	}
	
	public void UpdateDisplay(){
		powerText.text = power.ToString();
	}
}
