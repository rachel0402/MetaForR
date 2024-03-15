using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController1 : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    public float textDisplayTime = 1f; // ������ ǥ�õǴ� �ð�
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;

    void Start()
    {
        StartCoroutine(TextPractice());
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
        but3.gameObject.SetActive(false);
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
        yield return new WaitForSeconds(textDisplayTime);

        but1.gameObject.SetActive(true);
        but2.gameObject.SetActive(true);
        but3.gameObject.SetActive(true);

    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("���� ���� ū ����� �����ΰ���?"));
        
    }

}
