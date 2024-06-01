using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectorController : MonoBehaviour
{
    public GameObject puerta;
    public Animator puertaAnim;
    int numero;
    public bool derecha;
    public float delay = 3.0f; // Tiempo de espera en segundos
    private bool puedeEjecutar = true; // Controla si la acción puede ejecutarse
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
        if (other.CompareTag("ObjetoDeseado") && puedeEjecutar)
        {
            StartCoroutine(ActivarPuerta());
        }
    }
    private IEnumerator ActivarPuerta()
    {
        puedeEjecutar = false;

        if (derecha)
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
                GeneralSound.PlayDoorCloseSound();
            }
            numero++;
        }
        else
        {
            puertaAnim.enabled = true;
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

        yield return new WaitForSeconds(delay); // Espera el tiempo especificado

        puedeEjecutar = true; // Permite que la acción se ejecute nuevamente
    }
}
