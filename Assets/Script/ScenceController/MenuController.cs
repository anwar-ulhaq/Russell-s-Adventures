using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour {

	/// <summary>
	/// Starts the button.
	/// </summary>
	// click Start button to go to Map Scene
	public void startButton(){
		SceneManager.LoadScene ("Map");
	}

	/// <summary>
	/// Options the button.
	/// </summary>
	// click Option button to go to HighScore Scene
	public void optionButton(){
		SceneManager.LoadScene  ("HighScore");
	}

	/// <summary>
	/// Abouts the us button.
	/// </summary>
	// click AboutUs button to go to About Us Scene
	public void aboutUsButton(){
		SceneManager.LoadScene  ("AboutUs");
	}

	/// <summary>
	/// Exits the button.
	/// </summary>
	// click Exit button to close game
	public void exitButton(){
		Application.Quit();
	}
}
