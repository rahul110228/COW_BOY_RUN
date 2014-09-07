using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	

	public float runingScore = 0;

	void Update () {

		runingScore += Time.deltaTime;
		
	}
	
	public void IncreseScore(int ammount )
	{
		runingScore += ammount;
	}
	
	
	void OnGUI() {

		guiText.text = (int)(runingScore*10)+ " m";   

	}
}
