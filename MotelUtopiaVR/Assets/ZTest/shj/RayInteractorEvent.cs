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
        //�̺�Ʈ ��� �ֱ�? �̰� �ڵ�����θ� �߰��ϴ°��� public���� �������ְ�����
        rightControllerRayInteractor.selectEntered.AddListener(SelectEnterEvent);
        rightControllerRayInteractor.selectEntered.AddListener(SelectExitEvent);
    }

    private void SelectEnterEvent(SelectEnterEventArgs args)
    {
        //�α� �߰����ֱ�(public�������ֱ�)
    }
    private void SelectExitEvent(SelectEnterEventArgs args)
    {

    }
}
