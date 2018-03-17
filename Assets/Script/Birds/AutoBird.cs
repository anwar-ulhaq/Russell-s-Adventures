using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBird : MonoBehaviour {

	[SerializeField]
	private GameObject autoBird;
	public GameObject theCamera;

	public float appearFrequency;

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		StartCoroutine (Bird ());
	}

	// Create Birds automatically, continuously and randomly on y axis
	// Birds appear after a time variable (appearFrequency) and far from the right side of screen by calculating the distance betwween Camera's position to the right side.
	/// <summary>
	/// Bird this instance.
	/// </summary>
	IEnumerator Bird(){
		yield return new WaitForSeconds (appearFrequency);
		Vector3 temp = theCamera.transform.position;
		temp.y = Random.Range (-5f, 7f);
		temp.x = theCamera.transform.position.x + 30;
		temp.z = 5;
		GameObject newObject = Instantiate(autoBird, temp, Quaternion.identity) as GameObject;
		newObject.transform.localScale = new Vector3(autoBird.transform.localScale.x, autoBird.transform.localScale.y, autoBird.transform.localScale.z);
		StartCoroutine (Bird ());
	}
}
