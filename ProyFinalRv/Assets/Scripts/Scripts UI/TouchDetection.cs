using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    public Transform manoConRaycast; // Asigna la mano que tiene el raycast en el editor
    public GameObject canvasAActivar; // Asigna el canvas que quieres mostrar en el editor

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(manoConRaycast.position, manoConRaycast.forward, out hit))
        {
            // Comprueba si el raycast ha chocado con el objeto deseado
            if (hit.collider.gameObject.CompareTag("ObjetoDeseado"))
            {
                // Activa el canvas
                canvasAActivar.SetActive(true);
            }
            else
            {
                // Desactiva el canvas si el raycast no está tocando el objeto deseado
                canvasAActivar.SetActive(false);
            }
        }
        else
        {
            // Desactiva el canvas si el raycast no está chocando con nada
            canvasAActivar.SetActive(false);
        }
    }
}
