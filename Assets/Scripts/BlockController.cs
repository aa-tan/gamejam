using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

	public float speed;
	float verticalSpeed;
	Rigidbody2D block = new Rigidbody2D();
	// Use this for initialization
	void Start () {
		block = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		verticalSpeed = Input.GetAxis("Vertical");
		block.velocity = new Vector2(0, verticalSpeed) * speed;
	}
}
