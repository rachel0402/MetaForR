using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Selet : MonoBehaviour
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
        Grab.selectExited.AddListener(Set_NonGrab);
    }

    private void Set_Grab(SelectEnterEventArgs interactor)
    {
        particle.Play();
        particle2.Play();
    }

    private void Set_NonGrab(SelectExitEventArgs interacter)
    {
        Gravity.useGravity = true;
        GetComponentInParent<Grow>().time = -1f;
    }
}