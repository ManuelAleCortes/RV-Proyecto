using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public Transform head;
    public float spawnDistance = 2;
    public InputActionProperty showButton;

    void Start()
    {
        
        menu.SetActive(false);
    }

    
    void Update()
    {
        
        if (showButton.action.WasPressedThisFrame())
        {
            
            menu.SetActive(!menu.activeSelf);
        }
        /*
        if (menu.activeSelf) 
        {
            /*
            Vector3 adjustedHeadPosition = head.position;
            adjustedHeadPosition.y = 0; 

            menu.transform.position = adjustedHeadPosition + head.forward * spawnDistance;

            
            menu.transform.LookAt(head.position); 
            menu.transform.forward *= -1; 
            

        }
        */
    }

}
