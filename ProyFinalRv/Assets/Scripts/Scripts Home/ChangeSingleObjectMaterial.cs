using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSingleObjectMaterial : MonoBehaviour
{
    public Renderer vaseRenderer; 
    public Material[] newMaterials; 

    private int currentMaterialIndex = 0; 
    
    public void ChangeMaterialOnClick()
    {
        if (vaseRenderer != null && newMaterials.Length > 0)
        {
            
            currentMaterialIndex = (currentMaterialIndex + 1) % newMaterials.Length;

            
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
