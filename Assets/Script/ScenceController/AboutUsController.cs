using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUsController : MonoBehaviour {

	/// <summary>
	/// Backs the button.
	/// </summary>
	// move into Menu Scene
	public void BackButton(){
		SceneManager.LoadScene("Menu");
	}
}