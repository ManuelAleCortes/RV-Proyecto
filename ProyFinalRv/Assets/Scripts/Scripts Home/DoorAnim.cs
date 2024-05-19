using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    private Animator animador;
    int numero;
    public bool derecha;
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
        if(derecha == true) {
            if (numero % 2 == 0)
            {
                animador.SetBool("DoorClosing", false);
                GeneralSound.PlayDoorOpenSound();
            }
            else
            {
                animador.SetBool("DoorClosing", true);
                GeneralSound.PlayDoorCloseSound();
            }
            numero++;
        }
        else
        {
            if (numero % 2 == 0)
            {
                animador.SetBool("DoorClosingLeft", false);
                GeneralSound.PlayDoorOpenSound();
            }
            else
            {
                animador.SetBool("DoorClosingLeft", true);
                GeneralSound.PlayDoorCloseSound();
            }
            numero++;
        }

    }
}
