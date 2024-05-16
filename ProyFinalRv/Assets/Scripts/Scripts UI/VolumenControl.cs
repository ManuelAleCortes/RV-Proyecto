using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenControl : MonoBehaviour
{
    public Slider volumeSlider; 
    public AudioSource audioSource; 
    public Button pauseButton; 
    public Button playButton; 

    void Start()
    {
       
        volumeSlider.minValue = 0;
        volumeSlider.maxValue = 1;

        
        volumeSlider.value = 0;
        audioSource.volume = 0;

        
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
        pauseButton.onClick.AddListener(PauseAudio);
        playButton.onClick.AddListener(PlayAudio);
    }

    void OnVolumeChange(float value)
    {
        
        audioSource.volume = value;
    }

    void PauseAudio()
    {
       
        audioSource.Pause();
    }

    void PlayAudio()
    {
        // Reproducir el audio
        audioSource.Play();
    }
}
