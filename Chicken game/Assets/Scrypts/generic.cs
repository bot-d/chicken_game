using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class generic : MonoBehaviour {
	//position
	public float posX;
	
	public float posY;
	
	public float posZ;
	//rotate

	public float rotX;

	public float rotY;

	public float rotZ;
	public float rotW;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(posX,posY,posZ);
		transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);


		
	}
}
