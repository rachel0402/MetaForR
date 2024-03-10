using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomGrabInteraction : XRGrabInteractable
{
    public Transform right_grab_transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        if (interactor.CompareTag("Right Hand"))
        {
            interactor.attachTransform = right_grab_transform;
        }
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        
    }

    protected override void OnActivate(XRBaseInteractor interactor)
    {
        
    }
}
