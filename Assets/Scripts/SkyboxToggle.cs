using UnityEngine;

public class SkyboxToggle : MonoBehaviour
{
    private Material originalSkybox;
    public Material skyboxMaterial; // give value frm inspector in unity editor

    void Start()
    {
        // Store the current skybox material
        originalSkybox = RenderSettings.skybox;
    }

    public void ToggleSkybox()
    {
        if (RenderSettings.skybox == originalSkybox)
        {
            // Change to the skybox material
            RenderSettings.skybox = skyboxMaterial;
            Camera.main.clearFlags = CameraClearFlags.SolidColor; //Set clear flag
            Camera.main.backgroundColor = Color.clear; // Make background color transparent
        }
        else
        {
            // Reset to the original skybox
            RenderSettings.skybox = originalSkybox;
            Camera.main.clearFlags = CameraClearFlags.Skybox; // change back to Skybox
        }
    }
}
