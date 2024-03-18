using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Select : MonoBehaviour
{
    private XRGrabInteractable Grab;
    public ParticleSystem particle;
    public ParticleSystem particle2;
    public Rigidbody Gravity;
    public GameObject grow;

    private void Start()
    {
        First_grab();
    }

    private void First_grab()
    {
        Grab = GetComponent<XRGrabInteractable>();
        Gravity = GetComponent<Rigidbody>();
        Grab.selectEntered.AddListener(Set_Grab);
        Grab.selectExited.AddListener(Set_NonGrab);
    }

    private void Set_Grab(SelectEnterEventArgs interactor)
    {
        particle.Play();
        particle2.Play();
        grow.GetComponent<Grow>().time = -1f;
    }

    private void Set_NonGrab(SelectExitEventArgs interacter)
    {
        Gravity.useGravity = true;
    }
}