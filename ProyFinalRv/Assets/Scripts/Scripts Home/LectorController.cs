using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectorController : MonoBehaviour
{
    public GameObject puerta;
    private Animator puertaAnim;
    int numero;
    public bool derecha;
    // Start is called before the first frame update
    void Start()
    {
        puertaAnim = puerta.GetComponent<Animator>();
        numero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjetoDeseado"))
        {
            if (derecha == true) 
            { 
                puertaAnim.enabled = true;
                if (numero % 2 == 0)
                {
                    puertaAnim.SetBool("DoorClosing", false);
                        GeneralSound.PlayDoorOpenSound();
                 }
                else
                {
                    puertaAnim.SetBool("DoorClosing", true);
                }
                numero++;
            }
            else
            {
                if (numero % 2 == 0)
                {
                    puertaAnim.SetBool("DoorClosingLeft", false);
                    GeneralSound.PlayDoorOpenSound();
                }
                else
                {
                    puertaAnim.SetBool("DoorClosingLeft", true);
                    GeneralSound.PlayDoorCloseSound();
                }
                numero++;
            }
        }
        /*
        animador.enabled = true;
        if (derecha == true)
        {
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
        */
    }
}
