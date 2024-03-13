using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            GetComponentInChildren<Shader_last_leaf>().last_leaf = 1;
            GetComponentInParent<Grow>().time = 140f;
        }
    }
}
