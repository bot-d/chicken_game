using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour {

	public int winScore;

	public GameObject ScoreManager;

	int currentScore;

	public Text winText;

	 //Use this for initialization
	void Start () {
		winText.enabled = false; 
	}
	
	 //Update is called once per frame
	void Update () {
		foreach (ScoreManager sm in GameObject.FindObjectsOfType<ScoreManager>()) {
			
			currentScore = sm.score;
			print ("Current score = " + currentScore);
			if (winScore == currentScore) {
				print ("Win Score Reached =" + currentScore);
				winText.enabled = true;
			}
		}
	}
}