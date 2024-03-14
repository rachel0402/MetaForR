using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    public float textDisplayTime = 3f; // ������ ǥ�õǴ� �ð�
    public GameObject[] canvases; // �ٸ� Canvas���� ���� �迭
    private int currentCanvasIndex = 0; // ���� Canvas�� �ε���

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

        // ���� ������ ǥ���ϱ� ���� ���� ������ ��������� ��
        while (ChatText.text.Length > 0)
        {
            ChatText.text = ChatText.text.Substring(0, ChatText.text.Length - 1);
            yield return new WaitForSeconds(delayBetweenCharacters);
        }
        // ���� Canvas ��Ȱ��ȭ
        canvases[currentCanvasIndex].SetActive(false);

        // ���� Canvas �ε����� �̵�
        currentCanvasIndex = (currentCanvasIndex + 1) % canvases.Length;

        // ���� Canvas Ȱ��ȭ
        canvases[currentCanvasIndex].SetActive(true);
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("��! ����ʽÿ�. ���������Ǿƿ� ���� �� ȯ���մϴ�. ���� ȣ���� �˰� ���̳���?"));
        yield return StartCoroutine(NormalChat("���� ȣ���� �ӹ��ô� ���� ����� ������ �Ҿ��� ���� �ӿ��� ��� �� �ֵ��� ���͵帮�� �ֽ��ϴ�."));
        yield return StartCoroutine(NormalChat("���ݺ��� ���� �� ���� ������ �帮�� ���ϰ� ������ֽø� �˴ϴ�."));
    }

}
