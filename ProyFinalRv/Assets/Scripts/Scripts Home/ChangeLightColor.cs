using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLightColor : MonoBehaviour
{
    public Light pointLight; // Variable pública para la PointLight
    public Slider intensitySlider; // Referencia al Slider

    void Start()
    {
        // Inicializar el valor del Slider
        if (intensitySlider != null)
        {
            intensitySlider.minValue = 0;
            intensitySlider.maxValue = 2;
            intensitySlider.value = 1;
            intensitySlider.onValueChanged.AddListener(ChangeIntensity);
        }
    }

    // Método para cambiar el color de la luz a blanco
    public void ChangeToWhite()
    {
        if (pointLight != null)
        {
            pointLight.color = new Color32(229, 229, 229, 255); // Color blanco: #E5E5E5
        }
    }

    // Método para cambiar el color de la luz a amarillo
    public void ChangeToYellow()
    {
        if (pointLight != null)
        {
            pointLight.color = new Color32(255, 243, 152, 255); // Color amarillo: #FFF398
        }
    }

    // Método para cambiar el color de la luz a naranja
    public void ChangeToOrange()
    {
        if (pointLight != null)
        {
            pointLight.color = new Color32(255, 217, 165, 255); // Color naranja: #FFD9A5
        }
    }

    // Método para cambiar la intensidad de la luz
    public void ChangeIntensity(float intensity)
    {
        if (pointLight != null)
        {
            pointLight.intensity = intensity;
        }
    }
}
