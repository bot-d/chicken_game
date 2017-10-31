using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	// Use this for initialization
	

public float moveSpeed; 

public Transform target; 

public Transform chickenPen;

public int points = 10; 

void OnTriggerStay(Collider other){

	if(other.gameObject.name == "Player"){
		transform.LookAt(target);
		transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);

	}
	
}

 void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "player"){
			//add points to score
			ScoreManager.AddPoints(points);
			//send chicken to pen.
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	}

}