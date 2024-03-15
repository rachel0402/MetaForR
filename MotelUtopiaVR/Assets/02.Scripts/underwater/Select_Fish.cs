using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Select_Fish : MonoBehaviour
{
    private XRGrabInteractable Grab;
    public ParticleSystem particle;
    public ParticleSystem particle2;
    public Rigidbody Gravity;

    private void Start()
    {
        First_grab();
    }

    private void First_grab()
    {
        Grab = GetComponent<XRGrabInteractable>();
        Gravity = GetComponent<Rigidbody>();
        Grab.selectEntered.AddListener(Set_Grab);
    }

    private void Set_Grab(SelectEnterEventArgs interactor)
    {
        particle.Play();
        particle2.Play();
        Gravity.useGravity = true;
    }
}
