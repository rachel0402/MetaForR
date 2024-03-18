using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChatController4 : MonoBehaviour
{
    private string text;
    public TMP_Text targetText;
    private float delay = 0.125f;
    public GameObject objectA;
    public GameObject objectB;
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
                                                 //public float textDisplayTime = 1f; // ������ ǥ�õǴ� �ð�

    private bool isPanelActive = true;

    void Start()
    {
        text = targetText.text.ToString();
        targetText.text = " ";

        StartCoroutine(textPrint(delay));
    }

    IEnumerator textPrint(float d)
    {
        int count = 0;

        while (count != text.Length)
        {
            if (count < text.Length)
            {
                targetText.text += text[count].ToString();
                count++;
            }

            yield return new WaitForSeconds(delay);
        }
    
        if (isPanelActive)
        {
            MoveObjectA();
        }
    }


    void MoveObjectA()
    {
        // ������Ʈ A�� ������Ʈ B ���� �̵��ϴ� �ڵ带 ���⿡ �ۼ��մϴ�.
        // ���� ���:
        objectA.transform.position = objectB.transform.position + new Vector3(0, objectA.transform.localScale.y / 2 + objectB.transform.localScale.y / 2, 0);
        Debug.Log("Move object A to object B");
    }

    // �г��� ���¸� �����ϴ� �޼���
    public void SetPanelActive(bool isActive)
    {
        // isPanelActive = isActive;
    }

}
