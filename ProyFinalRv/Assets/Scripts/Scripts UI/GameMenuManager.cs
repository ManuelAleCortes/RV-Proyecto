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
            // Menu Positioning (Excluding Downward Movement)
            Vector3 adjustedHeadPosition = head.position;
            adjustedHeadPosition.y = 0; // Set the Y-axis to 0 to exclude downward movement

            menu.transform.position = adjustedHeadPosition + head.forward * spawnDistance;

            // Menu Facing (Including Upward Movement)
            menu.transform.LookAt(head.position); // Use the full player's head position
            menu.transform.forward *= -1; // Flip the menu's forward vector to face the player


        }
    }

}
