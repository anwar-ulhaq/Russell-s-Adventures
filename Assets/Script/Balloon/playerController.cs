using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
	
	public float speed;
	public float windSpeed;

	Rigidbody2D myBalloon;

	public Transform gunTip;
	public GameObject candy;
	public float fireRate;
	float nextFire = 0f;
	public int score = 0;

	public GameObject myBLExploision;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioClip DieClip, pingClip;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	// Use this for initialization
	void Awake () {
		myBalloon = GetComponent<Rigidbody2D> ();
	}

	/// <summary>
	/// Fixeds the update.
	/// </summary>
	// to Control Ballloon by pressing A S W D, fire a Candy with Space button. flow forward because of autoFly.
	void FixedUpdate () {
			float fly_x = Input.GetAxis ("Horizontal");
			float fly_y = Input.GetAxis ("Vertical");
			myBalloon.velocity = new Vector2 (fly_x * speed, fly_y * speed);
		if (Input.GetKeyDown(KeyCode.Space)) {
				fireCandy ();
			}
			autoFly ();
		}

	/// <summary>
	/// Autos the fly.
	/// </summary>
	// create Wind effect. push the balloon forward
	void autoFly(){
		Vector3 temp = transform.position;
		temp.x += windSpeed * Time.deltaTime;
		transform.position = temp;
		}

	/// <summary>
	/// Fires the candy.
	/// </summary>
	// fire next Candy after few seconds
	void fireCandy(){
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (candy, gunTip.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
			}
		}

	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="other">Other.</param>
	// The balloon is in collision with "Destination" Objects ==> WinGame Panel pops up, destroy the balloon.
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Destination") {
			Destroy (GetComponent<AutoBird> ());
			if (GameplayController.instance != null) {
				GameplayController.instance.WinGamePanel (); 
				}
			gameObject.SetActive(false);
			}
			
		// if in collision with "KillBalloon" or "Bird" Objects ==> GameOver Panel pops up, destroy the balloon, run audio
		if (other.gameObject.tag == "KillBalloon" || other.gameObject.tag == "Bird") {
			Destroy (GetComponent<AutoBird> ());
			Instantiate (myBLExploision, transform.position, Quaternion.identity);
			gameObject.SetActive(false);
			audioSource.PlayOneShot(DieClip);
			if (GameplayController.instance != null) {
				GameplayController.instance.BalloonBlown (score); 
				}
			}

		// if in collision with "Score" Objects ==> inscrease score, run audio
		if (other.gameObject.tag == "Score") {
			score++;
			audioSource.PlayOneShot(pingClip);
			if (GameplayController.instance != null) {
				GameplayController.instance.SetScore (score);
			}
		}
			
}
		
}