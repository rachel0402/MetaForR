//coder: shj

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public partial class UniverseScene : MonoBehaviour
{
    [SerializeField]
    UnityEvent startSceneEvent;
  
}
public partial class UniverseScene : MonoBehaviour
{
    private void Awake()
    {

    }

    private void Start()
    {
        startSceneEvent?.Invoke();
    }

    private void Initialize()
    {

    }
    private void Allocate()
    {

    }

}
