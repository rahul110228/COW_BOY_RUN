using UnityEngine;
using System.Collections;

public class RunningBoy : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;
	public float jumpSpeed = 5f;
	public float forwardSpeed = 1f;
	
	bool manJump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Do graphics and input update 
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			manJump = true;		
		}
	}
	
	//Do physics engines update here
	void FixedUpdate(){ 
		velocity.x = forwardSpeed;
		velocity += gravity * Time.deltaTime;
		
		if (manJump == true) {
			manJump = true;
			velocity += flapVelocity;
			if(velocity.y <0)
			{
				velocity.y = 0;
			}
			velocity += flapVelocity;
		}
		velocity = Vector3.ClampMagnitude (velocity, jumpSpeed);
		transform.position += velocity * Time.deltaTime;

		if (manJump) {
			rigidbody2D.AddForce(Vector2.up* jumpSpeed);
			manJump = false;
			
		}

		float angle = 0;
		if (velocity.y < 0) {
			angle = Mathf.Lerp(0, -90, -velocity.y /jumpSpeed);
		}
		transform.rotation = Quaternion.Euler (0, 0, angle);
	}
}
