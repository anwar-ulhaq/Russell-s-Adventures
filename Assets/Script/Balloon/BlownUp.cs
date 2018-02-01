using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlownUp : MonoBehaviour {

	// if you want your balloon could countinue to fly after several attacks.
	/*
	public float fullBalloon;
	float currentBalloon;

	public GameObject blowEffect;

	// Use this for initialization
	void Start () {
		currentBalloon = fullBalloon;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public  void addDamage (float damage){
		if (damage <= 0)
			return;
		currentBalloon -= damage;
		if (currentBalloon <= 0)
			blownAll (); 
	}
	void blownAll(){
		Instantiate (blowEffect, transform.position, transform.rotation);
		gameObject.SetActive(false);
	}
	*/

	//if you want you balloon blown up inmediously
	playerController myBalloon;
	public GameObject myBLExploision;

	void Awake(){
		myBalloon = GetComponent<playerController>();
	}

	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "KillBalloon" || other.gameObject.tag == "EatCandy") {
			Instantiate (myBLExploision, transform.position, transform.rotation);
			Destroy (gameObject);
		}	}
}
