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
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
    //public float textDisplayTime = 1f; //문장이 표시되는 시간

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

        // 모든 문자가 표시된 후 대기
        //yield return new WaitForSeconds(textDisplayTime);
        if (isPanelActive)
        {
            MoveObjectA();
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("자 그럼 이 키를 가지고 가시면 됩니다. 지내시는 동안 당신의 고민이 줄어들길 바라며..."));
        
    }

    void MoveObjectA()
    {
        // 오브젝트 A를 오브젝트 B 위로 이동하는 코드를 여기에 작성합니다.
        // 예를 들어:
        objectA.transform.position = objectB.transform.position + new Vector3(0, objectA.transform.localScale.y / 2 + objectB.transform.localScale.y / 2, 0);
        Debug.Log("Move object A to object B");
    }

    // 패널의 상태를 설정하는 메서드
    public void SetPanelActive(bool isActive)
    {
       // isPanelActive = isActive;
    }

}
