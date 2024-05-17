using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    private Animator animador;
    int numero;
    // Start is called before the first frame update
    void Start()
    {
        numero = 0;
        animador = GetComponent<Animator>();

        animador.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activar()
    {
        animador.enabled = true;
        if (numero % 2 == 0)
        {
            animador.SetBool("DoorClosing", false);
        }
        else
        {
            animador.SetBool("DoorClosing", true);
        }
        numero++;

    }
}
