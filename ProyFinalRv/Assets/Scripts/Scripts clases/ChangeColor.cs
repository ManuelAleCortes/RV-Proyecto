using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] materials; // Array para almacenar los materiales
    private int currentIndex = 0; // �ndice actual del material

    // M�todo para cambiar el material del cubo
    public void ChangeMaterial()
    {
        // Avanzar al siguiente material o volver al primero si llegamos al �ltimo
        currentIndex = (currentIndex + 1) % materials.Length;
        // Cambiar el material del cubo
        GetComponent<Renderer>().material = materials[currentIndex];
    }
}
