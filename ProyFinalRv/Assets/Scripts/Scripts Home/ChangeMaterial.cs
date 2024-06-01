using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeMaterial : MonoBehaviour
{
    public Renderer targetRendererPiso1;
    public Renderer targetRendererPiso2;
    public Material[] materialesNuevos;

    public int indexSeccionCasa = 1;
    public int numeroMaterial = 1;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;

    private int currentFloor = 1;

    private string[] seccionesCasaPiso1 = {
        "ninguna", "Piso de gimnasio", "Pared exterior piso 1", "Paredes de oficina",
        "Paredes de gimnasio", "Pasillo de cocina", "Marcos de puertas", "Paredes de la sala",
        "Paredes del ba�o", "Pasillo del patio", "Piso de la sala", "Piso del pasillo",
        "Piso del ba�o", "Piso de cocina", "Piso de oficina", "Marco de ventanas pared"
    };

    private string[] seccionesCasaPiso2 = {
        "Marco del balcon","Suelo pasillo","Suelo del balc�n", "Suelo del ba�o","Suelo cuarto 2",
        "Suelo cuarto 3","Paredes ba�o","paredes del pasillo","Paredes exteriores",
        "Paredes cuarto 2","Paredes cuarto 3","Paredes cuarto 1",
        "Borde de las puertas","Borde de las ventanas", "ninguno"
    };

    private string[] materiales = {
        "Madera caf�", "Ladrillo", "Ladrillo tenue", "Madera naranja", "Madera roja", "Madera azul", "Tela azul"
    };

    private void Start()
    {
        UpdateTexts();
    }

    private void Update()
    {
        
    }

    public void ChangeMaterialOnClick()
    {
        Renderer targetRenderer = currentFloor == 1 ? targetRendererPiso1 : targetRendererPiso2;

        if (targetRenderer != null)
        {
            
            Material[] materials = targetRenderer.materials;

            
            string[] seccionesCasa = currentFloor == 1 ? seccionesCasaPiso1 : seccionesCasaPiso2;

            if (indexSeccionCasa > 0 && indexSeccionCasa <= materials.Length &&
                numeroMaterial > 0 && numeroMaterial <= materialesNuevos.Length)
            {
                
                materials[indexSeccionCasa - 1] = materialesNuevos[numeroMaterial - 1];
                targetRenderer.materials = materials;
            }
            else
            {
                Debug.LogWarning("�ndice de material o secci�n fuera de rango.");
            }
        }
        else
        {
            Debug.LogWarning("Renderer objetivo no asignado.");
        }
    }

    public void SumarVarSeccion()
    {
        string[] seccionesCasa = currentFloor == 1 ? seccionesCasaPiso1 : seccionesCasaPiso2;
        if (indexSeccionCasa < seccionesCasa.Length)
        {
            indexSeccionCasa++;
            UpdateTexts();
        }
    }

    public void RestaVarSeccion()
    {
        if (indexSeccionCasa > 1)
        {
            indexSeccionCasa--;
            UpdateTexts();
        }
    }

    public void SumarVarMaterial()
    {
        if (numeroMaterial < materiales.Length)
        {
            numeroMaterial++;
            UpdateTexts();
        }
    }

    public void RestaVarMaterial()
    {
        if (numeroMaterial > 1)
        {
            numeroMaterial--;
            UpdateTexts();
        }
    }

    private void UpdateTexts()
    {
        string[] seccionesCasa = currentFloor == 1 ? seccionesCasaPiso1 : seccionesCasaPiso2;

        if (indexSeccionCasa > 0 && indexSeccionCasa <= seccionesCasa.Length)
        {
            texto.SetText(seccionesCasa[indexSeccionCasa - 1]);
        }
        else
        {
            texto.SetText("Secci�n desconocida");
        }

        if (numeroMaterial > 0 && numeroMaterial <= materiales.Length)
        {
            texto2.SetText(materiales[numeroMaterial - 1]);
        }
        else
        {
            texto2.SetText("Material desconocido");
        }
    }

    public void SetPiso1()
    {
        currentFloor = 1;
        indexSeccionCasa = 1;
        UpdateTexts();
    }

    public void SetPiso2()
    {
        currentFloor = 2;
        indexSeccionCasa = 1;
        UpdateTexts();
    }
}

