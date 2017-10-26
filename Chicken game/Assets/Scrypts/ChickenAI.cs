using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	// Use this for initialization
	

public float moveSpeed; 

public Transform enemy;
public Transform target; 

public Transform chickenPen;

void OnTriggerStay(Collider other)
{

	if(other.gameObject.name == "Player"){
		transform.LookAt(target);
		transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);

	}
	
}

 void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "player"){


			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	}

}