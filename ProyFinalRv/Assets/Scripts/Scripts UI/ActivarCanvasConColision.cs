using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCanvasConColision : MonoBehaviour
{
    public string tagObjetoDeseado = "ObjetoDeseado"; // El tag del objeto que deseas detectar
    public Collider manoDerechaCollider; // Asigna el collider de la mano derecha en el editor
    public GameObject canvasAActivar; // Asigna el canvas que quieres mostrar en el editor

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto con el tag predeterminado ha colisionado con la mano derecha
        if (other.CompareTag(tagObjetoDeseado) && other == manoDerechaCollider)
        {
            // Activa el canvas
            canvasAActivar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Comprueba si el objeto con el tag predeterminado ha dejado de colisionar con la mano derecha
        if (other.CompareTag(tagObjetoDeseado) && other == manoDerechaCollider)
        {
            // Desactiva el canvas
            canvasAActivar.SetActive(false);
        }
    }
}
