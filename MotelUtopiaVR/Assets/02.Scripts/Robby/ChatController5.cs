using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController5 : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    //public float textDisplayTime = 1f; // ������ ǥ�õǴ� �ð�

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
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("�� �׷� �� Ű�� ������ ���ø� �˴ϴ�.\n�����ô� ���� ����� ����� �پ��� �ٶ��..."));
        
    }

}
