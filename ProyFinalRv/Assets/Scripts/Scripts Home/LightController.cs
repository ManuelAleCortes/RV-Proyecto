using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightObject;
    int numero;
    // Start is called before the first frame update
    void Start()
    {
        numero = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnOff()
    {
        if( numero % 2 == 0)
        {
            lightObject.SetActive(true);
        }
        else
        {
            lightObject.SetActive(false);
        }
        GeneralSound.PlaySwitchSound();
        numero++;
    }
}
