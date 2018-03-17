using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCode : MonoBehaviour {
	
	public float objectSpeed;

	Rigidbody2D myObject;

	// Use this for initialization
	void Start () {
		myObject = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		autoFly();
	}

	/// <summary>
	/// Removes the force.
	/// </summary>
	// remove force
	public void removeForce(){
		myObject.velocity = new Vector2 (0, 0);
	}

	/// <summary>
	/// Autos the fly.
	/// </summary>
	// Bird direction
	void autoFly(){
		Vector3 temp = transform.position;
		temp.x -= objectSpeed * Time.deltaTime;
		transform.position = temp;

	}
}
