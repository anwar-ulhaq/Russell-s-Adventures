using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	
	public float speed;

	Rigidbody2D myBalloon;

	public Transform gunTip;
	public GameObject candy;
	float fireRate = 5f;
	float nextFire = 5f;

	// Use this for initialization
	void Start () {

		myBalloon = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float fly_x = Input.GetAxis ("Horizontal");
		float fly_y = Input.GetAxis ("Vertical");
		myBalloon.velocity = new Vector2 (fly_x * speed, fly_y*speed);

		if (Input.GetAxisRaw ("Fire1") >0 || Input.GetAxisRaw ("Jump") > 0)
			fireCandy ();
	}
	void fireCandy(){
		if (Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		Instantiate (candy, gunTip.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
		}
	}
}
