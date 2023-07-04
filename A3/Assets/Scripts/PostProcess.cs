using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcess : MonoBehaviour
{
    public Volume[] postProcessVolumes; // Array of Post-process Volume components

    private void Start()
    {
        // Disable post-processing effects initially for all volumes
        SetPostProcessingEnabled(false);
    }

    private void Update()
    {
        // Example: Toggle post-processing effects with a key press (e.g., X key)
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Toggle the enabled state of all post-process volumes
            bool isEnabled = !postProcessVolumes[0].enabled; // Use the first volume to check the current state
            SetPostProcessingEnabled(isEnabled);
        }
    }

    private void SetPostProcessingEnabled(bool isEnabled)
    {
        // Set the enabled state of all post-process volumes
        foreach (Volume volume in postProcessVolumes)
        {
            volume.enabled = isEnabled;
        }
    }
}

