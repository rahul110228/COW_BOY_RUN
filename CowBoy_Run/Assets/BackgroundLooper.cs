using UnityEngine;
using System.Collections;

public class BackgroundLooper : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Trigger :"+ collider.name);
	}
}
