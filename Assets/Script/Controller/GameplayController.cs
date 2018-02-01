using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {
	
	[SerializeField]
	public Button instructionButton;

	void Awake (){
		Time.timeScale = 0;
	}
	public void InstructionButtom(){
		Time.timeScale = 1;
		instructionButton.gameObject.SetActive (false);
	}

}
