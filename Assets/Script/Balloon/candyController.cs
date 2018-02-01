using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyController : MonoBehaviour {

	public float candySpeed;

	Rigidbody2D myCandy;

	void Awake(){
		myCandy = GetComponent<Rigidbody2D>();

		myCandy.AddForce(new Vector2(1, 0)*candySpeed, ForceMode2D.Impulse);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void removeForce(){
		myCandy.velocity = new Vector2 (0, 0);
	 }
}
