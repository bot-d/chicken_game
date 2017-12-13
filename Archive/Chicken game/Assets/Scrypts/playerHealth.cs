using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour{

	public const int maxHealth = 100;

	public int currentHealth = maxHealth;

	public Text hp;

	public Text maxHP;
	public Transform Playerspawnpoint;

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
	void OnCollisionEnter(Collision other){




		if (other.gameObject.name.Contains ("Wolf")) {
			//add points to score
			//ScoreManager.AddPoints (points);
			//send chicken to pen.
			transform.position = Playerspawnpoint.position;
			transform.rotation = Playerspawnpoint.rotation;

		}


		//pcHealth.TakeDamage(damage);
		//pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);



	}

}
