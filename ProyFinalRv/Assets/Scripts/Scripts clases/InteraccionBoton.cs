using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class InteraccionBoton : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRPushButton>().selectEntered.AddListener(e => DoorAction());
    }

    public void DoorAction()
    {
        Debug.Log("Click");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
