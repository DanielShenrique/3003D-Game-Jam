using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {

	public float vel;
	public float pontoA;
	public float pontoB;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(vel * Time.deltaTime, 0, 0);
		if (transform.position.x >= pontoA || transform.position.x <= pontoB)
		{
			vel *= -1;
		}
	}
}

