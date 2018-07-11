using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Static : MonoBehaviour {

   private string nome;
    private bool atordoado;
    private bool pegador;

    private GameObject text;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Player") {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        int c = 0;
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("ini").Length ; i++)
        {
            c++;
        }
        if (c <= 0)
        {
            SceneManager.LoadScene("Ganhou");
        }
        print(c + " conta");
    }
}
