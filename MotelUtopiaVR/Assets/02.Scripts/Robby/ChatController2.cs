using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController2 : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
    public float textDisplayTime = 1f; // 문장이 표시되는 시간
    public GameObject but1;
    public GameObject but2;

    void Start()
    {
        StartCoroutine(TextPractice());
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
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

        // 모든 문자가 표시된 후 대기
        yield return new WaitForSeconds(textDisplayTime);

        but1.gameObject.SetActive(true);
        but2.gameObject.SetActive(true);
 
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("흠.. 그래요, 혹시 제가 그 고민을 덜어낼 수 있는 방을 추천드려도 될까요 ? "));
        
    }

}
