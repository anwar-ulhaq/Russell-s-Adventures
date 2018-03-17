using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

	[SerializeField]
	public Button instructionButton;

	[SerializeField]
	public GameObject gameOverPanel, pausePanel;

	[SerializeField]
	public GameObject winGamePanel;

	[SerializeField]
	public static GameplayController instance;

	[SerializeField]
	private Text scoreText, endScoreText, bestScoreText;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	// freeze game and wait
	void Awake (){
		Time.timeScale = 0;
		MakeInstance ();
	}
	 
	/// <summary>
	/// Makes the instance.
	/// </summary>
	void MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	// press any key to start 
	void Update() {
		if (Input.anyKey) {
			Time.timeScale = 1;
			instructionButton.gameObject.SetActive (false);
			pausePanel.SetActive (false);
		}
	}

	/// <summary>
	/// Sets the score.
	/// </summary>
	/// <param name="score">Score.</param>
	// int to string
   	public void SetScore(int score){
		scoreText.text = "" + score;
		}

	/// <summary>
	/// Balloons the blown.
	/// </summary>
	/// <param name="score">Score.</param>
	// pop up GameOver, display end score and best score.
	public void BalloonBlown(int score){
		gameOverPanel.SetActive (true);
		endScoreText.text = "" + score;
		if (score > GameManager.instance.GetHighScore ()) {
			GameManager.instance.SetHighScore (score);
			}
		bestScoreText.text = "" + GameManager.instance.GetHighScore ();
	}

	/// <summary>
	/// Maps the button.
	/// </summary>
	//click Map button to load Map scene.
	public void MapButton(){
		SceneManager.LoadScene  ("Map");
	}

	/// <summary>
	/// Replaies the button.
	/// </summary>
	//click Replay button to replay current scene.
	public void ReplayButton(){
		Application.LoadLevel (Application.loadedLevel);
	}

	/// <summary>
	/// Windows the game panel.
	/// </summary>
	// WinGamePanel pops up
	public void WinGamePanel(){
		winGamePanel.SetActive (true);
	}

	/// <summary>
	/// Nexts the button.
	/// </summary>
	//click Next button to go to Map scene.
	public void NextButton(){ 
		SceneManager.LoadScene  ("Map");
	}

	/// <summary>
	/// Pauses the button.
	/// </summary>
	// click Pause Button to pause game
	public void PauseButton(){ 
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}
		
}
