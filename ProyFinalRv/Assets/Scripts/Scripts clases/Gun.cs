using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Gun : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;

    public DisparoRay disparo;
    // Start is called before the first frame update
    void Start()
    {
        grabInteractable.activated.AddListener(x => Disparo());

        grabInteractable.deactivated.AddListener(x => DejarDisparo());
    }

    public void Disparo()
    {
        disparo.Disparar();
    }

    public void DejarDisparo()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
