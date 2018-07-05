using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActPlayer : MonoBehaviour {

    public float spd;
    private Vector3 Mov;

	void Start ()
    {
        spd = 20f;
	}
	
	void Update () {
        Vector3 MovX = Camera.main.transform.right * Input.GetAxis("Horizontal") * spd;
        Vector3 MovZ = Camera.main.transform.forward * Input.GetAxis("Vertical") * spd;

        Mov = MovX + MovZ;
        Mov.y = 0;

        GetComponent<CharacterController>().Move(Mov * Time.deltaTime);

    }
}
