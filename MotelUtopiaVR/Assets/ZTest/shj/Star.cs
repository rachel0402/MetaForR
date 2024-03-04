using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Star : MonoBehaviour
{
    [SerializeField]
    UnityEvent activeEvent;
    [SerializeField]
    UnityEvent deactiveEvent;
    [SerializeField]
    UnityEvent finishEvent;

    [SerializeField]
    List<StarObject> starIndex = new List<StarObject>();


    public void Active()
    {
        activeEvent?.Invoke();
    }
    public void Deactive()
    {
        deactiveEvent?.Invoke();
    }
    public void Finish()
    {
     
        finishEvent?.Invoke();
    }
}
