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
