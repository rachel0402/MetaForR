using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SunflowerSocket : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public SunflowerGrowth growScript;

    void Awake()
    {
        // Ensure the socket interactor is assigned
        if (!socketInteractor)
            socketInteractor = GetComponent<XRSocketInteractor>();

        // Subscribe to the select entered event
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDestroy()
    {
        // Unsubscribe from the select entered event to clean up
        if (socketInteractor)
            socketInteractor.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs arg)
    {
        // Check if the entered object is the SunflowerSeed
        if (arg.interactable.CompareTag("SunflowerSeed"))
        {
            // Call the OnSeedPlanted method from the Grow script
            growScript.OnSeedPlanted();
        }
    }
}

