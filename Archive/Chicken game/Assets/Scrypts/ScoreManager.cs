using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour{

		public int score; 



	public int winScore;

	public Text text;
		
	public Text winText;
	

	// Use this for initialization
	void Start () {
		if (winScore == score) {
			print ("Win Score Reached = " + score);
			winText.GetComponent<Text> ().enabled = false;
			Time.timeScale = 0;
		}
		if (Input.GetKeyDown (KeyCode.Escape)){
			SceneManager.LoadScene (0);
		}

	}	
	

	void Update () {
		if(score < 0)
			score = 0;

		text.text =" " + score;
	}
	
	public void AddPoints(int pointsToAdd){

		score += pointsToAdd;	

	}

	public void Reset(){
		
		score=0; 
	}
	
	
	
}


