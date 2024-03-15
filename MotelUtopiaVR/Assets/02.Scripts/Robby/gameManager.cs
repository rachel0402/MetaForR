using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject text;

    public float delayInSeconds = 2f;


    void Start()
    {
        Invoke("ActivateCanvas", delayInSeconds);
    }

    void ActivateCanvas()
    {
        canvas.SetActive(true);
        text.SetActive(false);
        Invoke("Activatetext", delayInSeconds);

    }

    void Activatetext()
    {
        text.SetActive(true);
    }
}
