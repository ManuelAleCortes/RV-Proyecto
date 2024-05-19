using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSound : MonoBehaviour
{
    // Instancia est�tica del AudioManager
    public static GeneralSound Instance;

    // Referencias a los audio clips
    public AudioClip switchSound;
    public AudioClip doorOpenSound;
    public AudioClip doorCloseSound;

    private AudioSource audioSource;

    void Awake()
    {
        // Asegurarse de que solo hay una instancia del AudioManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Opcional: Para mantener el AudioManager entre escenas
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Obtener el componente AudioSource adjunto al objeto
        audioSource = GetComponent<AudioSource>();

        // Asegurarse de que el AudioSource no est� vac�o
        if (audioSource == null)
        {
            Debug.LogError("No se encontr� el componente AudioSource en este objeto.");
        }
    }

    // M�todo est�tico para reproducir el sonido del interruptor
    public static void PlaySwitchSound()
    {
        if (Instance != null && Instance.audioSource != null && Instance.switchSound != null)
        {
            Instance.audioSource.clip = Instance.switchSound;
            Instance.audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager no est� correctamente configurado o el audio clip de switch no est� asignado.");
        }
    }

    // M�todo est�tico para reproducir el sonido de una puerta abri�ndose
    public static void PlayDoorOpenSound()
    {
        if (Instance != null && Instance.audioSource != null && Instance.doorOpenSound != null)
        {
            Instance.audioSource.clip = Instance.doorOpenSound;
            Instance.audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager no est� correctamente configurado o el audio clip de door open no est� asignado.");
        }
    }

    // M�todo est�tico para reproducir el sonido de una puerta cerr�ndose
    public static void PlayDoorCloseSound()
    {
        if (Instance != null && Instance.audioSource != null && Instance.doorCloseSound != null)
        {
            Instance.audioSource.clip = Instance.doorCloseSound;
            Instance.audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager no est� correctamente configurado o el audio clip de door close no est� asignado.");
        }
    }
}
