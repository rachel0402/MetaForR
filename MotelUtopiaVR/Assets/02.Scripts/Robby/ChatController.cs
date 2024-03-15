using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
    public float textDisplayTime = 2f; // 문장이 표시되는 시간
    public GameObject[] panals; // 다른 Canvas들을 담을 배열
    private int currentCanvasIndex = 0; // 현재 Canvas의 인덱스

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
       yield return new WaitForSeconds(textDisplayTime);

        //ChatText.gameObject.SetActive(false);
        //yield return new WaitForSeconds(0.5f);
        //ChatText.gameObject.SetActive(true);


        if (narration.Length == 36)
        {
            // 현재 Canvas 비활성화
         panals[currentCanvasIndex].SetActive(false);

        // 다음 Canvas 인덱스로 이동
         currentCanvasIndex = (currentCanvasIndex + 1) % panals.Length;

        // 다음 Canvas 활성화
         panals[currentCanvasIndex].SetActive(true);

        }
       
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("오! 어서오십시오. 모텔유토피아에 오신 걸 환영합니다. 저희 호텔을 알고 오셨나요?"));
        yield return StartCoroutine(NormalChat("저희 호텔은 머무시는 동안 당신의 걱정과 불안을 마음 속에서 덜어낼 수 있도록 도와드리고 있습니다."));
        yield return StartCoroutine(NormalChat("지금부터 제가 몇 가지 질문을 드리면 편하게 대답해주시면 됩니다."));
    }

}
