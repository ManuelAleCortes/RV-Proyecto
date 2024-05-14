using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenControl : MonoBehaviour
{
    public Slider volumeSlider; // Referencia al slider de la UI
    public AudioSource audioSource; // Referencia al componente AudioSource

    void Start()
    {
        // Asegurarse de que el slider esté configurado entre 0 y 1
        volumeSlider.minValue = 0;
        volumeSlider.maxValue = 1;

        // Configurar el valor inicial del slider y el audio source a 0
        volumeSlider.value = 0;
        audioSource.volume = 0;

        // Agregar un listener al slider para que llame a la función OnVolumeChange cuando se cambie el valor
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
    }

    void OnVolumeChange(float value)
    {
        // Cambiar el volumen del audio source al valor del slider
        audioSource.volume = value;
    }
}
