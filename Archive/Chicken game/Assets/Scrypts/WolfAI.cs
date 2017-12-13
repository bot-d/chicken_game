using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	// Use this for initialization
	
public Transform wolfspawnpoint;

public float moveSpeed; 

public Transform target; 

public int damage;

public 

void OnTriggerStay(Collider other)
{

		if(other.gameObject.name == "Player" || other.gameObject.name.Contains("Chicky")){
			transform.LookAt(other.gameObject.transform.position);
			print ("blrgh");
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}
}	
	void OnCollisionEnter(Collision other){
	
		

			
			var hit = other.gameObject;
			var health = hit.GetComponent<playerHealth>();
			print("The Wolf is attacking");
			print (other.gameObject.name);
				//if(pcHealth != null){

		if (other.gameObject.name.Contains ("Projectile")) {
				//add points to score
				//ScoreManager.AddPoints (points);
				//send chicken to pen.
				transform.position = wolfspawnpoint.position;
				transform.rotation = wolfspawnpoint.rotation;

			}
					

					//pcHealth.TakeDamage(damage);
					//pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
		
				

			}
			
	}


	


		
	
	
	
