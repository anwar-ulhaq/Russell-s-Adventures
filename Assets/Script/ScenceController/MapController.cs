using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapController : MonoBehaviour {

	/// <summary>
	/// Pyramids the button.
	/// </summary>
	// click Pyramid button to go to Level 1 Scene
	public void pyramidButton(){
		SceneManager.LoadScene  ("Level1");
	}

	/// <summary>
	/// Gos the back.
	/// </summary>
	// click GoBack button to go to Menu Scene
	public void goBack(){
		SceneManager.LoadScene  ("Menu");
	}
}
