using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSingleObjectMaterial : MonoBehaviour
{
    public Renderer vaseRenderer; // Renderer component of the vase
    public Material[] newMaterials; // Array of new materials to apply

    private int currentMaterialIndex = 0; // Index to keep track of the current material

    // Method to change the material on button click
    public void ChangeMaterialOnClick()
    {
        if (vaseRenderer != null && newMaterials.Length > 0)
        {
            // Increment the material index
            currentMaterialIndex = (currentMaterialIndex + 1) % newMaterials.Length;

            // Apply the new material
            Material[] materials = vaseRenderer.materials;
            materials[0] = newMaterials[currentMaterialIndex];
            vaseRenderer.materials = materials;
        }
        else
        {
            Debug.LogWarning("Renderer or materials array not assigned.");
        }
    }
}
