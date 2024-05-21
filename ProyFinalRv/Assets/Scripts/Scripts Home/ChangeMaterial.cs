using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeMaterial : MonoBehaviour
{
    public Renderer targetRenderer;
    public Material[] materialesNuevos;
    
    public int indexSeccionCasa;
    public int numeroMaterial;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;
    string SeccionCasa;
    string material;
    public void ChangeMaterialOnClick()
    {
        // Obtener los materiales actuales del Renderer
        Material[] materials = targetRenderer.materials;//Lista de los materiales de las secciones

        // Cambiar el material en el índice especificado
        /*
        if (materialIndex >= 0 && materialIndex < materials.Length)
        {
            materials[materialIndex] = newMaterial[0];
            targetRenderer.materials = materials;
        }
        else
        {
            Debug.LogWarning("Índice de material fuera de rango.");
        }
        */
    }
    private void Update()
    {

        //---------------------------------------------index secciones de la casa
        if (indexSeccionCasa == 1)
        {
            SeccionCasa = "techo";
        }
        else if(indexSeccionCasa == 2){
            SeccionCasa = "piso";
        }
        //---------------------------------------------index lista materiales

        if (numeroMaterial == 1)
        {
            material = "gris";
        }
        else if (numeroMaterial == 2)
        {
            material = "Azul";
        }
    }
    public void SumarVarSeccion()
    {
        indexSeccionCasa++;
        texto.SetText(SeccionCasa.ToString());
    }
    public void RestaVarSeccion()
    {
        indexSeccionCasa--;
        texto.SetText(SeccionCasa.ToString());
    }
    public void SumarVarMaterial()
    {
        numeroMaterial++;
        texto2.SetText(material.ToString());
    }
    public void RestaVarMaterial()
    {
        numeroMaterial--;
        texto2.SetText(material.ToString());
    }
}
