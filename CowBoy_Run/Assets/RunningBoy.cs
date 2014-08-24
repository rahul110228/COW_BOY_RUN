using UnityEngine;
using System.Collections;

public class RunningBoy : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;
	public float maxSpeed = 5f;
	public float forwardSpeed = 1f;
	
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
		velocity.x = forwardSpeed;
		velocity += gravity * Time.deltaTime;
		
		if (dipFlap == true) {
			dipFlap = true;
			velocity += flapVelocity;
		}
		velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
		transform.position += velocity * Time.deltaTime;
	}
}
