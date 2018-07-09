using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAround : MonoBehaviour {


    public Vector3 movDir;

    public float maxDist;

	// Use this for initialization
	void Start () {
        if (GetComponent<Static>().Pegador == false)
        {
           movDir = ChooseDirection();
        }
    }
	
	// Update is called once per frame
	void Update () {
        Vector3.MoveTowards(transform.position,movDir, 2f);

	}


    Vector3 ChooseDirection()
    {
        System.Random random = new System.Random();
        int i = random.Next(0 , 3);
        Vector3 temp = new Vector3();

        if(i == 0)
        {
            temp = transform.forward;
        }
        if(i == 1)
        {
            temp = -transform.forward;
        }
        if(i == 2)
        {
            temp = transform.forward;
        }
        if(i == 3)
        {
            temp = -transform.forward;
        }

        return temp;
    }
}
