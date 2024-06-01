using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioRadio : MonoBehaviour
{
    public Slider volumeSlider; // Asigna el slider desde el inspector
    public AudioSource audioSource; // Asigna el AudioSource desde el inspector

    void Start()
    {
        // Inicializa el slider en el punto medio y configura su valor mínimo y máximo
        volumeSlider.minValue = 0f;
        volumeSlider.maxValue = 1f;
        volumeSlider.value = 0.5f;

        // Configura el volumen del AudioSource al valor inicial del slider
        audioSource.volume = volumeSlider.value;

        // Añade el listener para actualizar el volumen cuando el slider cambie
        volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Método para actualizar el volumen
    void OnSliderValueChanged(float value)
    {
        audioSource.volume = value;
    }

    // Método para iniciar la música
    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Método para detener la música
    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
