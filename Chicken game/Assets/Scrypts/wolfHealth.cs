﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {

	public int currentHealth;

	public int maxHealth = 3;

	public Transform spawnPoint;

	public int points = 10;

	 void Start(){
		currentHealth = maxHealth;
	}



	public void TakeDamage(int amount){
		currentHealth -= amount;
		if (currentHealth <= 0) {
			//keep score at zero
			currentHealth = 0;
			print ("Wolf has died!");
			//add points to score for killing wolf
		}
	}
	void  OnCollisionEnter(Collision other){
		if (other.gameObject.name.Contains( "Projectile")) {
					//add points to score
					foreach (ScoreManager sm in GameObject.FindObjectsOfType<ScoreManager>()) {
						sm.AddPoints (points);
					}
			//move wolf to spawn point for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation; 
			//reset wolf health 
			currentHealth = maxHealth;
		}
	}

}
