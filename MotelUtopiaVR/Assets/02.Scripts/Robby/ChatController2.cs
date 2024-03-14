using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController2 : MonoBehaviour
{
    public Text ChatText;
    public string writerText = "";
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    public float textDisplayTime = 3f; // ������ ǥ�õǴ� �ð�
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

        // ��� ���ڰ� ǥ�õ� �� ���
        yield return new WaitForSeconds(textDisplayTime);

        chat.canvases[currentCanvasIndex].SetActive(false);

        // ���� Canvas �ε����� �̵�
        currentCanvasIndex = (currentCanvasIndex + 1) % chat.canvases.Length;

        // ���� Canvas Ȱ��ȭ
        chat.canvases[currentCanvasIndex].SetActive(true);

    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("���ݺ��� ���� �� ���� ������ �帮�� ���ϰ� ������ֽø� �˴ϴ�."));
    }
}
