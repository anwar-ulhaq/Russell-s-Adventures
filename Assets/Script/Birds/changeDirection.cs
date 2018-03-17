using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDirection : MonoBehaviour {

	FlyingCode theObject;

	void Awake(){
		theObject = GetComponent<FlyingCode>();
	} 

	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="other">Other.</param>
	//Destroy Birds in collision with Candy
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Candy") {
			theObject.removeForce ();
			gameObject.SetActive (false);
		}	
	}
}
