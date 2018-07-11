using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    Text txt;
    int printDis;
    float timer=61;

	// Use this for initialization
	void Start () {
        txt = this.GetComponent<Text>();
            }
	
	// Update is called once per frame
	void Update () {
        if (timer > 1)
        {
            timer -= Time.deltaTime;

            printDis = (int)timer;
            txt.text = "" + printDis;
        }
        else {
            SceneManager.LoadScene("Perdeu");
        }
	}
}
