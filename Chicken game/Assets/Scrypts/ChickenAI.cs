using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : Wander {

	// Use this for initialization
	

	public float moveSpeed; 

	public Transform target; 

	public Transform chickenPen;

	public int points = 10; 

	private bool isCaught = false;

	protected override void Start()
	{
		base.Start ();

	}

	protected override void Update() {
		//Debug.Log (isCaught);

		if (!isCaught) {
			base.roam ();
		}
	}

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);

		}
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player") {
			//add points to score
			ScoreManager.AddPoints (points);
			//send chicken to pen.
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			isCaught = true;
		} else if (other.gameObject != null) {
			print (other.gameObject.name);
			print (other.gameObject.tag);
		}
	}

}