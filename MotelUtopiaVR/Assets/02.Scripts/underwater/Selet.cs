using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Selet : MonoBehaviour
{
    private XRGrabInteractable Grab;
    private Rigidbody Drag;

    private void Start()
    {
        First_grab();
    }

    private void First_grab()
    {
        Grab = GetComponent<XRGrabInteractable>();
        Drag = GetComponent<Rigidbody>();
        Grab.firstSelectEntered.AddListener(Settime);
    }

    private void Settime(SelectEnterEventArgs interactor)
    {
        GetComponentInParent<Grow>().time = -1f;
        Drag.drag = 0;
    }
}