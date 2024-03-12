using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Material Chage;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            GetComponent<Shader_last_leaf>().last_leaf = 1;
        }
    }
}
