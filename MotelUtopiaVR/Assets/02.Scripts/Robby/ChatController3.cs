using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController3 : MonoBehaviour
{
    public Text ChatText;

    public GameObject objectA;
    public GameObject objectB;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    //public float textDisplayTime = 1f; //������ ǥ�õǴ� �ð�

  private bool isPanelActive =true;

    void Start()
    {
        StartCoroutine(TextPractice());
    }


    IEnumerator NormalChat(string narration)
    {
        writerText = "";

        for (int a = 0; a < narration.Length; a++)
        {
            Debug.Log(narration.Length);
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(delayBetweenCharacters);
        }

        // ��� ���ڰ� ǥ�õ� �� ���
        //yield return new WaitForSeconds(textDisplayTime);
        if (isPanelActive)
        {
            MoveObjectA();
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("�� �׷� �� Ű�� ������ ���ø� �˴ϴ�. �����ô� ���� ����� ����� �پ��� �ٶ��..."));
        
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
