using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour {

	public float damage;
	float dameRate = 0.5f;
	public float pushBackForce;
	float nextdamage;

	// Use this for initialization
	void Start () {
		nextdamage = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*
	 * void OntriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" && nextdamage < Time.time) {
			BlownUp theBlowUp = other.gameObject.GetComponent<BlownUp> ();
			theBlowUp.addDamage (damage);
			nextdamage = dameRate + Time.time;
			pushBack (other.transform);
			Destroy (gameObject);
		}
	}
	void pushBack (Transform pushedObject){
		Vector2 pushDirection = new Vector2 (0, (pushedObject.position.y - transform.position.y)).normalized;
		pushDirection *= pushBackForce;
		Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D> ();
		pushRB.velocity = Vector2.zero;
		pushRB.AddForce (pushDirection, ForceMode2D.Impulse);
	}
	*/
}
