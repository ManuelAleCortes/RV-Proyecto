using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightObject;
    public GameObject canvasUi;
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
            canvasUi.SetActive(true);
        }
        else
        {
            lightObject.SetActive(false);
            canvasUi.SetActive(false);
        }
        GeneralSound.PlaySwitchSound();
        numero++;
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
