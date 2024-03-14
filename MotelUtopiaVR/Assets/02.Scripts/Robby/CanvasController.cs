using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject[] canvases;

    // Canvas를 활성화하는 메서드
    public void ActivateCanvas(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            canvases[index].SetActive(true);
        }
    }

    // Canvas를 비활성화하는 메서드
    public void DeactivateCanvas(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            canvases[index].SetActive(false);
        }
    }
}
