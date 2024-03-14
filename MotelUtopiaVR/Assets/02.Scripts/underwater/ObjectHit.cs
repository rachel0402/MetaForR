using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public GameObject HitObject;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == HitObject)
        {
            GetComponentInChildren<Shader_last_leaf>().last_leaf = 1;
            GetComponentInParent<Grow>().time = 0f;
        }
    }
}
