using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIText : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject canvas;
    public int Delay = 12;
    private int i;
    private float time;
    private string[] Story = new string[]
    {
        "�� �濡�� �޽��� ���� �غ� �Ǽ̳���?",
        "���ݺ��� ����� �� �ӿ��� �޽��� ���ϰ� �˴ϴ�.",
        "�� ���� �ӿ� ���� ������ �Ĺ����� �����մϴ�.",
        "�ð��� �帧�� ���� �����ϰ�, \n�� �ڶ� �Ŀ� ������� ���� �ݺ�����.",
        "��Ȳ�� ��Ǯ�� ����⿡�� ���� �� ���� �ֽ��ϴ�.",
        "���ϴ� ��ġ�� �̵����� �� ������ ���پ� ������.",
        "�׷� ����� �ð� �ǽñ� �ٶ�ڽ��ϴ�."
    };

    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 5)
        {
            Text_Update(i);
            time = 0;
        }
    }
    private void Text_Update(int j)
    {
        if(j== 7)
        {
            canvas.SetActive(false);
        }
        else
        {
            Text.text = Story[j];
            i++;
        }
    }
}
