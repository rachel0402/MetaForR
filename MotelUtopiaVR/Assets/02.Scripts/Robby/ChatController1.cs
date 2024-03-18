using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChatController1 : MonoBehaviour
{
    private string text;
    public TMP_Text targetText;
    private float delay = 0.125f;

    public GameObject but1;
    public GameObject but2;
    public GameObject but3;

    void Start()
    {
        text = targetText.text.ToString();
        targetText.text = " ";

        StartCoroutine(textPrint(delay));
        but1.gameObject.SetActive(false);
        but2.gameObject.SetActive(false);
        but3.gameObject.SetActive(false);
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
    

        but1.gameObject.SetActive(true);
        but2.gameObject.SetActive(true);
        but3.gameObject.SetActive(true);

    }
}
