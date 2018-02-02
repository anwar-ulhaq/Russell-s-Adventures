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

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioClip bgClip, dieClip;

	private bool isAlive;

	// Use this for initialization
	void Awake () {
		isAlive = true;
		myBalloon = GetComponent<Rigidbody2D> ();
		audioSource.PlayOneShot (bgClip);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isAlive) {
			float fly_x = Input.GetAxis ("Horizontal");
			float fly_y = Input.GetAxis ("Vertical");
			myBalloon.velocity = new Vector2 (fly_x * speed, fly_y * speed);

			if (Input.GetAxisRaw ("Fire1") > 0 || Input.GetAxisRaw ("Jump") > 0)
				fireCandy ();
		}
		if (isAlive == false)
			audioSource.PlayOneShot (dieClip);
	}
	void fireCandy(){
		if (Time.time > nextFire)
		{
		nextFire = Time.time + fireRate;
		Instantiate (candy, gunTip.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
		}
	}

}
