using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private const string HIGHT_SCORE = "High Score";

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake(){
		MakeSingleInstance ();
		TheFirstTimePlay ();
	}

	/// <summary>
	/// Thes the first time play.
	/// </summary>
	//set score to 0 at first time
	void TheFirstTimePlay(){
		if (!PlayerPrefs.HasKey ("TheFirstTimePlay")) {
			PlayerPrefs.SetInt (HIGHT_SCORE, 0);
			PlayerPrefs.SetInt ("TheFirstTimePlay", 0);
		}
	}

	/// <summary>
	/// Makes the single instance.
	/// </summary>
	// avoid douple creating Gamemanager Object
	void MakeSingleInstance(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	/// <summary>
	/// Sets the high score.
	/// </summary>
	/// <param name="score">Score.</param>
	// take High Score value
	public void SetHighScore (int score){
		PlayerPrefs.SetInt (HIGHT_SCORE, score);
	}

	/// <summary>
	/// Gets the high score.
	/// </summary>
	/// <returns>The high score.</returns>
	// display High Score
	public int GetHighScore (){
		return PlayerPrefs.GetInt (HIGHT_SCORE);
	}
}
