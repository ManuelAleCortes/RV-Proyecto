using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject lightObject;
    public GameObject canvasUi;
    public int numero;
    public bool visible;
    public bool prendido;
    // Start is called before the first frame update
    void Start()
    {
        numero = 0;
        visible = false;
        prendido = false;
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
            prendido = true;
            
        }
        else
        {
            lightObject.SetActive(false);
            prendido = false;
            
        }
        GeneralSound.PlaySwitchSound();
        numero++;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            canvasUi.SetActive(false);
        }
        else
        {
            canvasUi.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        visible = false;
    }
}
