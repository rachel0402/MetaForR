using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



//shj
public class RayInteractorEvent : MonoBehaviour
{
    [SerializeField]
    XRRayInteractor rightControllerRayInteractor;

    private void Start()
    {
        //이벤트 기능 넣기? 이건 코드상으로만 추가하는거임 public으로 유동성있게하자
        rightControllerRayInteractor.selectEntered.AddListener(SelectEnterEvent);
        rightControllerRayInteractor.selectEntered.AddListener(SelectExitEvent);
    }

    private void SelectEnterEvent(SelectEnterEventArgs args)
    {
        //로그 추가해주기(public으로해주기)
    }
    private void SelectExitEvent(SelectEnterEventArgs args)
    {

    }
}
