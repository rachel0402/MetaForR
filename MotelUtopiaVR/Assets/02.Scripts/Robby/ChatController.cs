using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatController : MonoBehaviour
{
    public Text ChatText;

    public string writerText = ""; 
    public float delayBetweenCharacters = 0.05f; // ���� ���� ������ �ð�
    public float textDisplayTime = 2f; // ������ ǥ�õǴ� �ð�
    public GameObject[] panals; // �ٸ� Canvas���� ���� �迭
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
            Debug.Log(narration.Length);
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(delayBetweenCharacters);
        }

        // ��� ���ڰ� ǥ�õ� �� ���
       yield return new WaitForSeconds(textDisplayTime);

        //ChatText.gameObject.SetActive(false);
        //yield return new WaitForSeconds(0.5f);
        //ChatText.gameObject.SetActive(true);


        if (narration.Length == 36)
        {
            // ���� Canvas ��Ȱ��ȭ
         panals[currentCanvasIndex].SetActive(false);

        // ���� Canvas �ε����� �̵�
         currentCanvasIndex = (currentCanvasIndex + 1) % panals.Length;

        // ���� Canvas Ȱ��ȭ
         panals[currentCanvasIndex].SetActive(true);

        }
       
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("��! ����ʽÿ�. ���������Ǿƿ� ���� �� ȯ���մϴ�. ���� ȣ���� �˰� ���̳���?"));
        yield return StartCoroutine(NormalChat("���� ȣ���� �ӹ��ô� ���� ����� ������ �Ҿ��� ���� �ӿ��� ��� �� �ֵ��� ���͵帮�� �ֽ��ϴ�."));
        yield return StartCoroutine(NormalChat("���ݺ��� ���� �� ���� ������ �帮�� ���ϰ� ������ֽø� �˴ϴ�."));
    }

}
