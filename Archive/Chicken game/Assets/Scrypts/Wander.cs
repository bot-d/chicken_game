using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {



	public float duration;    //the max time of a walking session (set to ten)
	float elapsedTime   = 0f; //time since started walk
	float wait          = 0f; //wait this much time
	float waitTime      = 0f; //waited this much time

	float randomX;  //randomly go this X direction
	float randomZ;  //randomly go this Z direction

	bool move = true; //start moving

	protected virtual void Start(){
		randomX =  Random.Range(-3,3);
		randomZ = Random.Range(-3,3);
		duration = 2f;
	}

 	protected virtual void Update()
	{
		roam ();
	}

	protected void roam ()
	{
		//Debug.Log (elapsedTime);

		if (move) {
			if (elapsedTime < duration) {
				//if its moving and didn't move too much
				transform.Translate (new Vector3 (randomX, 0, randomZ) * Time.deltaTime);
				elapsedTime += Time.deltaTime;

			} else {
				//do not move and start waiting for random time
				move = false;
				wait = Random.Range (1, 2);
				waitTime = 0f;
				duration = Random.Range (1, 3);
			}
		} else {

			if (waitTime < wait) {
				//you are waiting
				waitTime += Time.deltaTime;

			} else {
				//done waiting. Move to these random directions
				move = true;
				elapsedTime = 0f;
				randomX = Random.Range (-3, 3);
				randomZ = Random.Range (-3, 3);
			}
		}
	}
}
