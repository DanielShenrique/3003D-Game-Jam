using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour {

	public float vel;
	public float pontoA;
	public float pontoB;
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<Static>().Pegador == false)
		{
			if(GetComponent<Static>().Congelado == false)
			{
				transform.Translate(vel * Time.deltaTime, 0, 0);
				if (transform.position.x >= pontoA || transform.position.x <= pontoB)
				{
					vel *= -1;
				}
			}
			if(GetComponent<Static>().Congelado == true)
			{
				Destroy(this.gameObject);

			}

		}
	}

	private void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.GetComponent<Static>().Pegador == true)
		{
			GetComponent<Static>().Congelado = true;
		}
	}
}

