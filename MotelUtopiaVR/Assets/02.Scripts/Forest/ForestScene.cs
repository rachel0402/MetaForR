using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ForestScene : MonoBehaviour
{
    [SerializeField]
    UnityEvent startSceneEvent;

    private void Awake()
    {

        startSceneEvent?.Invoke();
    }

    private void Start()
    {
    }

    private void Initialize()
    {

    }
    private void Allocate()
    {

    }
}
