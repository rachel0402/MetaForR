using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ToPlant : MonoBehaviour
{
    public XRController xrController; // XR ��Ʈ�ѷ�
    public Canvas canvasToDeactivate; // ��Ȱ��ȭ�� ĵ����
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
        // ĵ������ ��Ȱ��ȭ�մϴ�.
        canvasToDeactivate.gameObject.SetActive(false);
        canvasToActivate.gameObject.SetActive(true);
    }
}
