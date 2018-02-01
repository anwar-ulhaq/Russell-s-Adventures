using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyHit : MonoBehaviour {

	candyController myCC;


	public GameObject candyExploision; 

	void Awake(){
		myCC = GetComponent<candyController>();

	} 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "EatCandy") {
			myCC.removeForce ();
			Instantiate (candyExploision, transform.position, transform.rotation);
			Destroy (gameObject);
		}	}
}
