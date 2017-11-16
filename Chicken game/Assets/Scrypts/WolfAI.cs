using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	// Use this for initialization
	

public float moveSpeed; 

public Transform target; 

public int damage;

public 

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "Player"){
		transform.LookAt(target);
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}
}	
	void OnCollisionEnter(Collision other){
	
		

			if(other.gameObject.name == "player"){
			var hit = other.gameObject;
			var health = hit.GetComponent<playerHealth>();
			print("The Wolf is attacking");
				//if(pcHealth != null){
					

					//pcHealth.TakeDamage(damage);
					//pcHealth.gameObject.GetComponent<playerHealth>().TakeDamage(damage);
		
				}

			}
			
	}


	


		
	
	
	
