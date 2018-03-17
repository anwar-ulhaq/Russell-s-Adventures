using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyController : MonoBehaviour {

	public float candySpeed;

	Rigidbody2D myCandy;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	// Give the Candy a Force to fly
	void Awake(){
		myCandy = GetComponent<Rigidbody2D>();
		myCandy.AddForce(new Vector2(1, 0)*candySpeed, ForceMode2D.Impulse);
	}

	/// <summary>
	/// Removes the force.
	/// </summary>
	//Stop it
	public void removeForce(){
		myCandy.velocity = new Vector2 (0, 0);
	 }
}
