using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCode : MonoBehaviour {
	
	public float objectSpeed;

	Rigidbody2D myObject;

	/*
	void wake(){

		myObject = GetComponent<Rigidbody2D>;

		myObject.AddForce (new Vector2 (-1,0)*objectSpeed);

	}
	*/

	// Use this for initialization
	void Start () {
		myObject = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		//myObject.AddForce (new Vector2 (-1,0)*objectSpeed,ForceMode2D.Impulse);
		autoFly();
	}
	public void removeForce(){
		myObject.velocity = new Vector2 (0, 0);
	}
	void autoFly(){
		Vector3 temp = transform.position;
		temp.x -= objectSpeed * Time.deltaTime;
		transform.position = temp;

	}
}
