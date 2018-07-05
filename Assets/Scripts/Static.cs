using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Static : MonoBehaviour {

    public string nome;
    private bool atordoado;
    private bool congelado;
    private bool pegador;

    public GameObject text;

    public bool Pegador {
        get {
            return pegador;
        }
        set {
            pegador = value;

            if (pegador)
            {
                text.GetComponent<Text>().text = nome;
                StartCoroutine(Mostrar());
            }
        }
    }

    public bool Congelado
    {
        get
        {
            return congelado;
        }
        set
        {
            congelado = value;
            if (congelado) {
                int c = 0;
                foreach (GameObject g in GameObject.Find("GameController").GetComponent<GOOD>().players) {
                    if (g.GetComponent<Static>().Congelado) {
                        c++;
                    }
                }
                if (c == GameObject.Find("GameController").GetComponent<GOOD>().players.Length -1) {
                    print("pegador wins");
                }
            }
        }
    }
    public bool Atordoado
    {
        get
        {
            return atordoado;
        }
        set
        {
            atordoado = value;
            if (atordoado) {
                StartCoroutine(Movase());
            }
        }
    }

    IEnumerator Mostrar()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        text.SetActive(false);
    }
    IEnumerator Movase()
    {
        yield return new WaitForSeconds(1.5f);
        atordoado = false;
    }

}
