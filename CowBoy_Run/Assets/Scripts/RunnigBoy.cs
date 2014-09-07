
using UnityEngine;
using System.Collections;

public class RunnigBoy : MonoBehaviour {
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public float forwardSpeed = 3f; 
	public float jumpSpeed = 50f;
	public GameObject[] obs=new GameObject[2];
	bool manJump = false;
	Animator animator ;
	private uint coins = 0;
	public Texture2D coinIconTexture;
	public AudioClip coinCollectSound;


	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0)) {
			animator.SetBool("jump",true);
			rigidbody2D.AddForce(Vector2.up* jumpSpeed);
		}
		//Random r = new Random ();
		/*if (Random.Range (1, 10) < 5) 
		{
			Instantiate(obs[0],Camera.main.tran*form.position,Quaternion.identity);
		}
		else if(Random.Range(1,10000)==1)
			obs[1].SetActive(true);*/

	}
	

	void FixedUpdate(){

		velocity.x = forwardSpeed;
		velocity += gravity * Time.deltaTime;
		velocity = Vector3.ClampMagnitude (velocity, forwardSpeed);
		transform.position += velocity * Time.deltaTime;

		//rigidbody2D.AddForce (Vector2.right * forwardSpeed);
		if (manJump) {
			rigidbody2D.AddForce(Vector2.up* jumpSpeed);
			manJump = false;

		}
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.tag=="ground")
				animator.SetBool("jump",false);


	}

	void CollectCoin(Collider2D coinCollider)
	{
		coins++;
		
		Destroy(coinCollider.gameObject);
		AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.CompareTag ("Coins")) {
						CollectCoin (collider);
				}
	}

	void DisplayCoinsCount()
	{
		Rect coinIconRect = new Rect(10, 10, 32, 32);
		GUI.DrawTexture(coinIconRect, coinIconTexture);                         
		
		GUIStyle style = new GUIStyle();
		style.fontSize = 30;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.yellow;
		
		Rect labelRect = new Rect(coinIconRect.xMax, coinIconRect.y, 60, 32);
		GUI.Label(labelRect, coins.ToString(), style);

	}

	void OnGUI()
	{
		DisplayCoinsCount();

	}
	
}
