using UnityEngine;
using System.Collections;

public class GroundProtect : MonoBehaviour {
	float speed = 0.5f;

	void FixedUpdate ()
	{
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime; 
		transform.position = pos;
	}
}