using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour {

	/// <summary>
	/// Gos the back.
	/// </summary>
	// click GoBack button to go to Menu Scene
	public void goBack(){
		SceneManager.LoadScene  ("Menu");
	}
}
