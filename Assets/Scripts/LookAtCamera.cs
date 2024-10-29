using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    void Update()
    {
        //camera object to refer to main camera
        Camera camera = Camera.main;
        if (camera != null)
        {
            // Make the button look at the camera
            transform.LookAt(camera.transform);
            
        }
    }
}
