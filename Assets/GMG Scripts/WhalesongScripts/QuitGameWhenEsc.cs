using UnityEngine;

public class QuitGameWhenEsc : MonoBehaviour
{
    void Update()
    {
        // Check if the Escape key is pressed down
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quit the application
            Application.Quit();

            // For Unity Editor: Log a message for debugging within the Unity Editor
            Debug.Log("Quit game requested.");

            // Important Note for Unity Editor:
            // Application.Quit() does not stop play mode in the Editor.
        }
    }
}
