using UnityEngine;
using System.Collections;

public class BackgroundLooper : MonoBehaviour {

	int numBackgrounPanels = 4;
	void OnTriggerEnter2D(Collider2D collider)
	{
		//Debug.Log ("Triggered "+ collider.name);
		float widthOfBackgroundObject = ((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += widthOfBackgroundObject * numBackgrounPanels - widthOfBackgroundObject/3f;
		collider.transform.position = pos;
	}

}
