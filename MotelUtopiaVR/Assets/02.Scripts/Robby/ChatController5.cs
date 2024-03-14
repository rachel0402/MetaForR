using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController5 : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
    //public float textDisplayTime = 1f; // 문장이 표시되는 시간

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

        // 모든 문자가 표시된 후 대기
        //yield return new WaitForSeconds(textDisplayTime);
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("자 그럼 이 키를 가지고 가시면 됩니다.\n지내시는 동안 당신의 고민이 줄어들길 바라며..."));
        
    }

}
