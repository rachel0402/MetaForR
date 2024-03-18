using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChatController4 : MonoBehaviour
{
    private string text;
    public TMP_Text targetText;
    private float delay = 0.125f;
    public GameObject objectA;
    public GameObject objectB;
    public float delayBetweenCharacters = 0.05f; // 문자 간의 딜레이 시간
                                                 //public float textDisplayTime = 1f; // 문장이 표시되는 시간

    private bool isPanelActive = true;

    void Start()
    {
        text = targetText.text.ToString();
        targetText.text = " ";

        StartCoroutine(textPrint(delay));
    }

    IEnumerator textPrint(float d)
    {
        int count = 0;

        while (count != text.Length)
        {
            if (count < text.Length)
            {
                targetText.text += text[count].ToString();
                count++;
            }

            yield return new WaitForSeconds(delay);
        }
    
        if (isPanelActive)
        {
            MoveObjectA();
        }
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
