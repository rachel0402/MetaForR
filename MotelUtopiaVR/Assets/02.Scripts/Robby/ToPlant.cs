using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ToPlant : MonoBehaviour
{
    public XRController xrController; // XR 컨트롤러
    public Canvas canvasToDeactivate; // 비활성화할 캔버스
    public Canvas canvasToActivate;

    private XRDirectInteractor interactor;

    void Start()
    {
        interactor = xrController.gameObject.GetComponent<XRDirectInteractor>();
        interactor.onSelectEntered.AddListener(OnButtonPress);
    }

    private void OnDestroy()
    {
        interactor.onSelectEntered.RemoveListener(OnButtonPress);
    }

    void OnButtonPress(XRBaseInteractable interactable)
    {
        // 캔버스를 비활성화합니다.
        canvasToDeactivate.gameObject.SetActive(false);
        canvasToActivate.gameObject.SetActive(true);
    }
}
