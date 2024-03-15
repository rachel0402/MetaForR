using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ObjectHit_Fish : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Fish")
        {
            GetComponentInChildren<Shader_Fish>().Hit = true;
            other.gameObject.GetComponent<Random_Move>().Count = 1;
            GetComponent<Select_Fish>().particle.Stop();
            GetComponent<Select_Fish>().particle2.Stop();
        }
    }
}
