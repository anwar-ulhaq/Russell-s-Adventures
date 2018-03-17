using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMe : MonoBehaviour {

	public float aliveTime;

	/// <summary>
	/// Start this instance.
	/// </summary>
	// Automatically destroy after a while.
	void Start () {
		Destroy (gameObject, aliveTime);
	}

}
