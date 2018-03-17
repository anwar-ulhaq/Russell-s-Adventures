using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing;

	Vector3 offset;

	/// <summary>
	/// Start this instance.
	/// </summary>
	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
	}
		
	// Update is called once per frame
	// Camera follows the Balloon based on its position
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		Vector3 targetCampos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCampos, smoothing * Time.deltaTime);
			transform.position = new Vector3 (transform.position.x, 0, transform.position.z);
		
	}
}
