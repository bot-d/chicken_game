using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	// Use this for initialization
	

public Rigidbody enemy; 

public float moveSpeed; 

public Transform target; 

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "Player"){
		transform.LookAt(target);
		transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);

	}
	
}

		
	
	
	// Update is called once per frame
	
}