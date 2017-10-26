﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

	// Use this for initialization

public float speed;
		public float randomX;
		public float randomZ;
		public float minWaitTime;
		public float maxWaitTime;
		private Vector3 currentRandomPos;



	void Start () {
	PickPosition();	
	}

	void PickPosition(){
	currentRandomPos = new Vector3(Random.Range(-randomX, randomX), 0, Random.Range(-randomZ, randomZ));	
	StartCoroutine ( MoveToRandomPos());

	}

	IEnumerator MoveToRandomPos(){
	
	float i = 0.0f;
	float rate = 1.0f / speed;
	Vector3 currentPos = transform.position;

	while (i < 1.0f)
	{
	i += Time.deltaTime * rate;
	transform.position = Vector3.Lerp( currentPos, currentRandomPos, i);
	yield return null;
	} 
	
	float randomFloat = Random.Range(0.0f,1.0f);
	if(randomFloat < 0.5f)
	StartCoroutine ( WaitForSomeTime());
	else
	PickPosition();
	}

	IEnumerator WaitForSomeTime()
	{
	yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
	PickPosition();
	}


	// Update is called once per frame
	void Update () {
		
	}
}
