using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyHit : MonoBehaviour {

	candyController myCC;

	/// <summary>
	/// The candy exploision.
	/// </summary>
	public GameObject candyExploision; 

	/// <summary>
	/// Awake this instance.
	/// </summary>
	// get Candy Component
	void Awake(){
		myCC = GetComponent<candyController>();
	} 

	// Candy is in collision with other objects tagged "Bird"
	// An exploision appears and the Candy disapears
	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="other">Other.</param>
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Bird") {
			myCC.removeForce ();
			Instantiate (candyExploision, transform.position, transform.rotation);
			Destroy (gameObject);
		}	
	}
}
