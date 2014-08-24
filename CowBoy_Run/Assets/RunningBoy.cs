using UnityEngine;
using System.Collections;

public class RunningBoy : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	//public Vector3 flapVelocity;
	//public float maxSpeed = 5f;
	public float forwardSpeed = 1f;
	public float jumpSpeed = 50f;

	Animator animator;
	bool manJump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Do graphics and input update 
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			animator.SetBool("jump",true);;
			manJump = true;		
		}
	} 
	
	//Do physics engines update here
	void FixedUpdate(){ 
		rigidbody2D.AddForce (Vector2.right * forwardSpeed);
		if (manJump) {
			rigidbody2D.AddForce (Vector2.up * jumpSpeed);
			manJump = false;
		}

		void OnCollisionEnter2D(Collision2D collision)
		{
			if(collision.collider.tag=="ground")
				animator.SetBool("jump",false);
		}

	} 
}
