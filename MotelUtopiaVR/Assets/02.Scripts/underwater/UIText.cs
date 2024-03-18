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
        "이 방에서 휴식을 취할 준비가 되셨나요?",
        "지금부터 당신은 물 속에서 휴식을 취하게 됩니다.",
        "이 공간 속엔 여러 종류의 식물들이 존재합니다.",
        "시간의 흐름에 따라 성장하고, \n다 자란 후엔 사라지는 것을 반복하죠.",
        "주황색 수풀로 물고기에게 힘을 줄 수도 있습니다.",
        "원하는 위치에 이동시켜 이 공간을 가꾸어 보세요.",
        "그럼 편안한 시간 되시길 바라겠습니다."
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
