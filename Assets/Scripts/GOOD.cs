using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOOD : MonoBehaviour {

    public GameObject[] players;

	void Start () {
        Random.seed = System.DateTime.Now.Millisecond;
        int i = Random.Range(0, 3);

        players[i].GetComponent<Static>().Pegador = true;

	}
	

}
