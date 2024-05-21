using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeMaterial : MonoBehaviour
{
    public Renderer targetRenderer;
    public Material[] materialesNuevos;

    public int indexSeccionCasa = 1;
    public int numeroMaterial = 1;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;

    private string[] seccionesCasa = {
        "TechoCasaInterior", "PisoGym", "ParedExteriorHome", "ParedesCuartoOficina",
        "ParedesGym", "ParedesPasilloCocina", "MarcosPuertas", "ParedesSala",
        "ParedesBathroom", "PasilloPatioAtras", "PisoSala", "PisoPasillo",
        "PisoBathroom", "PisoCocina", "PisoOficina", "MarcoVentanaPared"
    };

    private string[] materiales = {
        "gris", "Azul", "Rojo", "Verde", "Amarillo", "Naranja", "Café"
    };

    private void Start()
    {
        UpdateTexts();
    }

    private void Update()
    {
        // Los textos se actualizan automáticamente en cada cambio de índice
    }

    public void ChangeMaterialOnClick()
    {
        if (targetRenderer != null)
        {
            // Obtener los materiales actuales del Renderer
            Material[] materials = targetRenderer.materials;

            // Verificar que el índice de la sección y el índice del material sean válidos
            if (indexSeccionCasa > 0 && indexSeccionCasa <= materials.Length &&
                numeroMaterial > 0 && numeroMaterial <= materialesNuevos.Length)
            {
                // Aplicar el material seleccionado a la sección correspondiente
                materials[indexSeccionCasa - 1] = materialesNuevos[numeroMaterial - 1];
                targetRenderer.materials = materials;
            }
            else
            {
                Debug.LogWarning("Índice de material o sección fuera de rango.");
            }
        }
        else
        {
            Debug.LogWarning("Renderer objetivo no asignado.");
        }
    }

    public void SumarVarSeccion()
    {
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
        if (indexSeccionCasa > 0 && indexSeccionCasa <= seccionesCasa.Length)
        {
            texto.SetText(seccionesCasa[indexSeccionCasa - 1]);
        }
        else
        {
            texto.SetText("Sección desconocida");
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
}

