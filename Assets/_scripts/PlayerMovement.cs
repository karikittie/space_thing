using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 30f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.transform.position = new Vector3 (0, 0, 0);
	}

	void Update(){
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 rbVelocity = new Vector3 (horizontal, 0, vertical) * speed;

		rb.AddRelativeForce(rbVelocity);
	}
}
