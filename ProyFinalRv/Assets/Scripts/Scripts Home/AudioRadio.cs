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
        // Inicializa el slider en el punto medio y configura su valor m�nimo y m�ximo
        volumeSlider.minValue = 0f;
        volumeSlider.maxValue = 1f;
        volumeSlider.value = 0.5f;

        // Configura el volumen del AudioSource al valor inicial del slider
        audioSource.volume = volumeSlider.value;

        // A�ade el listener para actualizar el volumen cuando el slider cambie
        volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // M�todo para actualizar el volumen
    void OnSliderValueChanged(float value)
    {
        audioSource.volume = value;
    }

    // M�todo para iniciar la m�sica
    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // M�todo para detener la m�sica
    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
