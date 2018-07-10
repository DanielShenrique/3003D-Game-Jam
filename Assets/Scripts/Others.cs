using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Others : MonoBehaviour {

    private GameObject[] objects;

    private Vector3 destiny;

    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        if (GetComponent<Static>().Pegador == true)
        {
            destiny = new Vector3(10000, 10000, 10000);
            foreach (GameObject g in objects)
            {
                if (g.GetInstanceID() != gameObject.GetInstanceID())
                {
                    if (Vector3.Distance(g.transform.position, transform.position) < Vector3.Distance(destiny, transform.position))
                    {
                        destiny = g.transform.position;
                    }
                }

            }
            GetComponent<NavMeshAgent>().destination = destiny;
        }    
    }

	private void OnCollisionEnter(Collision coll)
	{
		if(GetComponent<Static>().Pegador == true)
		{
			if (coll.gameObject.tag.Equals("Player"))
			{
				coll.gameObject.GetComponent<Static>().Congelado = true;
			}
		}
	}
}
