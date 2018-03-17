using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HighScoreController : MonoBehaviour {

	/// <summary>
	/// Gos the back.
	/// </summary>
	// click GoBack button to go to Menu Scene
	public void goBack(){
		SceneManager.LoadScene  ("Menu");
	}
}
