using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody Projectile; 

	//public Transform shootPoint;

	public int speed = 20;


	void Update (){
		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone; 
			//clone = (Rigidbody)Instantiate(projectile, shootPoint.position, projectile.rotation);

			clone = Instantiate(Projectile, transform.position, transform.rotation);
			clone.velocity = transform.TransformDirection(0, 0, speed);
			//clone.velocity = shootPoint.TransformDirection 
			//(Vector3.forward*shootSpeed);
			Destroy (clone.gameObject, 3);

		}
		
	}
}
