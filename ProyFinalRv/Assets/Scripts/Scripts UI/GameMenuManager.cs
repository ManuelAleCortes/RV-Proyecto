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
        // Initialize menu state (e.g., hidden)
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // Toggle menu visibility
            menu.SetActive(!menu.activeSelf);
        }

        if (menu.activeSelf) // Only update if the menu is active
        {
            // Update menu position relative to player's head
            menu.transform.position = head.position + head.forward * spawnDistance;

            // Keep menu facing the player (excluding Y-axis)
            menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
            menu.transform.forward *= -1;
        }
    }
}
