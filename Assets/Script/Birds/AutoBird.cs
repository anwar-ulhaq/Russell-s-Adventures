using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBird : MonoBehaviour {

	[SerializeField]
	private GameObject autoBird;
	public GameObject theBalloon;

	public float appearFrequency;

	// Use this for initialization
	void Start () {
		StartCoroutine (Bird ());
	}
	
	IEnumerator Bird(){
		/*yield return new WaitForSeconds (appearFrequency);
		//Vector3 temp = autoBird.transform.position;
		//temp.y = Random.Range (-5f, 5f);
		//temp.x = autoBird.transform.position.x;
		Instantiate (autoBird, transform.position, Quaternion.identity);
		StartCoroutine (Bird ());
		*/
		yield return new WaitForSeconds (appearFrequency);
		Vector3 temp = theBalloon.transform.position;
		temp.y = Random.Range (-5f, 5f);
		temp.x = theBalloon.transform.position.x + 40;
		Instantiate (autoBird, temp, Quaternion.identity);
		StartCoroutine (Bird ());

	}
}
