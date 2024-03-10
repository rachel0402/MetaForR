using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public partial class StarObject : MonoBehaviour
{
    Star star;

    public bool isActive = false;
}
public partial class StarObject : MonoBehaviour
{
    public void Initialize(Star starValue)
    {
        star = starValue;
    }
}
public partial class StarObject : MonoBehaviour
{

    

    public void StarCheck()
    {
        Debug.Log("StarCheck");

        SetActiveState(true);
        //���� �����ٸ�
        star.StarCheck();
    }

    private void SetActiveState(bool state)
    {
        isActive = state;
    }

}
