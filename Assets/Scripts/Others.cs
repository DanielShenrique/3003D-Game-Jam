using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Others : MonoBehaviour {


	private GameObject[] targets;

	private void Start()
	{
		targets = GameObject.FindGameObjectsWithTag("Player");
	}


	private void Update()
	{
		if (gameObject.GetComponent<Static>().Pegador == true)
		{
			foreach (GameObject g in targets)
			{
				foreach (Transform[] t in g.GetComponent<Transform>())
				{
					GetClosestOther(t);
				}
			}
		}	
	}


	void GetClosestOther(Transform[] t_others)
	{
	}
}
