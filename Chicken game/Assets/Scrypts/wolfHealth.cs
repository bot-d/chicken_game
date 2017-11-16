using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {

	public int currentHealth;

	public int maxHealth = 3;

	public Transform spawnPoint;

	public int points;



	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			//keep score at zero
			currentHealth=0;
			print("Wolf has died!");
			//add points to score for killing wolf
			ScoreManager.AddPoints(points);
			//move wolf to spawn point for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation; 
			//reset wolf health 
			currentHealth = maxHealth;
		}
	}

}
