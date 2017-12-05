using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour{

	public const int maxHealth = 10;

	public int currentHealth = maxHealth;

	public Text hp;

	public Text maxHP;

	void Start () {
		//hp = new Text ("foo");
		//maxHP = new Text ("bar");
	}

	void Update () {
		//hp.text = currentHealth.ToString();
		//maxHP.text = maxHealth.ToString();	
	}

	public void TakeDamage(int amount){
		currentHealth -= amount; 
		if(currentHealth <=0){
			currentHealth=0;
			print("you're Dead! Game Over McDonald!");
		}

	}


}
