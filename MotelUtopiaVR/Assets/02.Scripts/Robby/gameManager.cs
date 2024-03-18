using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject canvas;

    public float delayInSeconds = 2f;


    void Start()
    {
        Invoke("ActivateCanvas", delayInSeconds);
    }

    void ActivateCanvas()
    {
        canvas.SetActive(true);


    }

}
