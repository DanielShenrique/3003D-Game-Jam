using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mov : MonoBehaviour {

	private NavMeshAgent nav;
	private GameObject[] randomPoints;
	private int currentRandom;

	private void Start()
	{
		nav = this.gameObject.GetComponent<NavMeshAgent>();
		randomPoints = GameObject.FindGameObjectsWithTag("RandomPoint");
	}

	private void Update()
	{
		if (GetComponent<Static>().Pegador == false) {

			if (nav.hasPath == false)
			{
				currentRandom = Random.Range(0, randomPoints.Length - 1);
				nav.SetDestination(randomPoints[currentRandom].transform.position);
			}
		}
	}
}

