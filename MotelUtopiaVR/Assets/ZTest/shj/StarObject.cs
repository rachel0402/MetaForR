using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarObject : MonoBehaviour
{
    Star star;

    public bool isActive = false;

    public void Initialize(Star starValue)
    {
        star = starValue;
    }

    List<GameObject> starIndex = new List<GameObject>();

    public void StarIndexCheck()
    {
        //만약 끝났다면
        star.Finish();
    }

    public void SetActiveState(bool state)
    {
        isActive = state;
    }

    public bool ActiveState()
    {
        return isActive;
    }
}
