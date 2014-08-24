using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int startTime=0;
	public int stageTime=0;
	//GUIText guiText;
	void Start () {
		startTime = (int)Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent (GUIText).text = Time.time.ToString; 
		stageTime = (int)Time.time - startTime;

	}
	void OnGUI() {
		//GUI.Label(new Rect(10, 10, 150, 150), stageTime.ToString());
		//GUIText.te (stageTime.ToString());
		guiText.text = stageTime.ToString()+ " m";        
	}
}
