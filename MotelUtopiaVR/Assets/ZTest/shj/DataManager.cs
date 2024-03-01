using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//shj
//XRI Default Input Actions 더블클릭하기
public class DataManager : MonoBehaviour
{
    public InputActionAsset inputActionAsset;

    private void Update()
    {
        Vector3 hmdPosition = inputActionAsset.actionMaps[0].actions[0].ReadValue<Vector3>();

        //Debug.Log(hmdPosition);

        var rightControllerTrigger = inputActionAsset.actionMaps[5].actions[2].ReadValue<float>();
        var rightControllerTrigger2 = inputActionAsset.actionMaps[5].actions[2].ReadValue<bool>();
    }
}
