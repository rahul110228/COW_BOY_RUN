using UnityEngine;
using System.Collections;

public class RunningBoy : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	//public Vector3 flapVelocity;
	//public float maxSpeed = 5f;
	public float forwardSpeed = 1f;
	public float jumpSpeed = 9.8f;

	
	bool dipFlap = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Do graphics and input update 
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			dipFlap = true;		
		}
	} 
	
	//Do physics engines update here
	void FixedUpdate(){ 
		rigidbody2D.AddForce (Vector2.right * forwardSpeed);
		rigidbody2D.AddForce (Vector2.up * jumpSpeed);

	} 
}
