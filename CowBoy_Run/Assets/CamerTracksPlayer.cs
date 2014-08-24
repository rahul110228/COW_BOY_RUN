using UnityEngine;
using System.Collections;

public class CamerTracksPlayer : MonoBehaviour {
	Transform player;
	float offsetx;
	// Use this for initialization
	void Start () {
		GameObject player_move = GameObject.FindGameObjectWithTag ("Player");
		player = player_move.transform;
		offsetx = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetx;
			transform.position = pos;
		}
	}
}
