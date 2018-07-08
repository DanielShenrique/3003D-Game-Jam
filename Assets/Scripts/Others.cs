using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Others : MonoBehaviour {


	private GameObject others;

	private void Start()
	{
		others = GameObject.FindGameObjectWithTag("Player");
	}

	private void Update()
	{

		if (gameObject.GetComponent<Static>().Pegador == true)
		{
			GetComponent<NavMeshAgent>().destination = others.transform.position;
		}

	}
}
