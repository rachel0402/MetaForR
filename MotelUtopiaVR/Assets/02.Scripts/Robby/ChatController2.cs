using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController2 : MonoBehaviour
{
    public Text ChatText;
    public string writerText = "";
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
    public float textDisplayTime = 3f; // 문장이 표시되는 시간
    int currentCanvasIndex = 1;

    ChatController chat;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextPractice());
    }

    IEnumerator NormalChat(string narration)
    {
        writerText = "";

        for (int a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(delayBetweenCharacters);
        }

        // 모든 문자가 표시된 후 대기
        yield return new WaitForSeconds(textDisplayTime);

        chat.canvases[currentCanvasIndex].SetActive(false);

        // 다음 Canvas 인덱스로 이동
        currentCanvasIndex = (currentCanvasIndex + 1) % chat.canvases.Length;

        // 다음 Canvas 활성화
        chat.canvases[currentCanvasIndex].SetActive(true);

    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("지금부터 제가 몇 가지 질문을 드리면 편하게 대답해주시면 됩니다."));
    }
}
