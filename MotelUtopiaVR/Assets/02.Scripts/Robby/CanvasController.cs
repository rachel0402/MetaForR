using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject[] canvases;

    // Canvas�� Ȱ��ȭ�ϴ� �޼���
    public void ActivateCanvas(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            canvases[index].SetActive(true);
        }
    }

    // Canvas�� ��Ȱ��ȭ�ϴ� �޼���
    public void DeactivateCanvas(int index)
    {
        if (index >= 0 && index < canvases.Length)
        {
            canvases[index].SetActive(false);
        }
    }
}
