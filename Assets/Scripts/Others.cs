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
            foreach (GameObject g in objects)
            {
                destiny = Vector3.zero;
                /*if ()
                {

                }*/
            }
        }    
    }
}
