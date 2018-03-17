using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadVictoryScene : MonoBehaviour {

	/// <summary>
	/// Raises the collision enter2 d event.
	/// </summary>
	/// <param name="col">Col.</param>
	// touch "Victory" object to go to Victory Scene
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel ("Victory");
		}
	}
}
