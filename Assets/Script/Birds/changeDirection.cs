using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDirection : MonoBehaviour {

	FlyingCode theObject;
	// Use this for initialization

	void Awake(){
		theObject = GetComponent<FlyingCode>();

	} 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Candy") {
			theObject.removeForce ();
			Destroy (gameObject);
		}	}}
