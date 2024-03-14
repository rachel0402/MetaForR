using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//이렇게 짜면 안됨니다...ㅠㅠ 시간이 없어서...

public partial class dialog : MonoBehaviour
{
    [SerializeField]
    private Text txt_Dialogue;

    [SerializeField]
    GameObject frame;



    string[] startNarrationArray = new string[3];
    string[] hintNarrationArray = new string[2];

    string[] andromedaNarrationArray = new string[1];
    string[] lionNarrationArray = new string[1];
    string[] swanNarrationArray = new string[1];
    string[] twinsNarrationArray = new string[1];


    bool isStart = false;
    bool isHint = false;
    bool isandroid = false;
    bool isLion = false;
    bool isSwan = false;
    bool isTwin = false;


    private float timer = 0;

    private void Awake()
    {
        SetNarration();
    }

    void Update()
    {
        if (isStart)
        {
            StartNarration();
        }
        if (isHint)
        {
            HintNarration();
        }
        if (isandroid)
        {
            AndromedaNarration();
        }
        if (isLion)
        {
            LionNarration();
        }
        if (isSwan)
        {
            SwanNarration();
        }
        if (isTwin)
        {
            TwinsNarration();
        }
    }


}
public partial class dialog : MonoBehaviour
{
    private void SetNarration()
    {


        startNarrationArray[0] = "환영합니다 이 방은 Connection Room 입니다";
        startNarrationArray[1] = "Connection Room 에서는 별자리를 연결하며 휴식을 취할 수 있습니다. 별자리를 하나씩 잇다보면 당신만의 우주가 완성됩니다. 각 별자리가 지닌 의미와 이야기에 귀 기울이며 평화로운 시간 보내시길 바랍니다.";
        startNarrationArray[2] = "앞에 보이는 별빛들로 둘러쌓인 공간으로 이동하면 4가지의 작은 별자리들을 볼 수 있습니다. 만들고 싶은 별자리를 선택해보세요.";

        hintNarrationArray[0] = "위 힌트지는 별의 모양, 이름, 밝기를 제공하며 우주 속의 별들을 연결하여 별자리를 완성하는 데 도움을 줍니다";
        hintNarrationArray[1] = "창문 밖에 보이는 별들을 관찰하고 힌트지의 정보를 바탕으로 가장 밝은 별부터 차례로 선택해주세요";

        andromedaNarrationArray[0] = "축하합니다! 안드로메다 자리를 완성했습니다. 완성한 별자리의 별들을 가까이서 보고싶다면 방안을 둘러보세요.";

        lionNarrationArray[0] = "축하합니다! 사자자리를 완성했습니다. 완성한 별자리의 별들을 가까이서 보고싶다면 방안을 둘러보세요.";

        swanNarrationArray[0] = "축하합니다! 백조자리를 완성했습니다. 완성한 별자리의 별들을 가까이서 보고싶다면 방안을 둘러보세요.";

        twinsNarrationArray[0] = "축하합니다! 쌍둥이자리를 완성했습니다. 완성한 별자리의 별들을 가까이서 보고싶다면 방안을 둘러보세요.";
    }


    private void SetActiveState(bool state)
    {
        frame.SetActive(state);
    }


    int narrationstep = 0;
    public void StartDialogActive()
    {
        SetActiveState(true);
        isStart = true;
    }
    public void HintDialogActive()
    {
        SetActiveState(true);

        isHint = true;
    }
    public void AndromedaDialogActive()
    {
        SetActiveState(true);

        isandroid = true;
    }
    public void LionDialogActive()
    {
        SetActiveState(true);

        isLion = true;
    }
    public void SwanDialogActive()
    {
        SetActiveState(true);

        isSwan = true;
    }
    public void TwinDialogActive()
    {
        SetActiveState(true);

        isTwin = true;
    }

    [SerializeField]
    int MaxTime = 4;
    private void StartNarration()
    {
        if (isStart)
        {
            txt_Dialogue.text = startNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= startNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < startNarrationArray.Length - 1)
                    {

                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isStart = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }
            }
        }
    }

    private void HintNarration()
    {
        if (isHint)
        {
            txt_Dialogue.text = hintNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= hintNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < hintNarrationArray.Length - 1)
                    {

                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isHint = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }
            }
        }
    }
    private void AndromedaNarration()
    {
        if (isandroid)
        {
            txt_Dialogue.text = andromedaNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= andromedaNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < andromedaNarrationArray.Length - 1)
                    {

                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isandroid = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }
            }
        }

    }
    private void LionNarration()
    {
        if (isLion)
        {
            txt_Dialogue.text = lionNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= lionNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < lionNarrationArray.Length - 1)
                    {

                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isLion = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }

            }
        }

    }
    private void SwanNarration()
    {
        if (isSwan)
        {
            txt_Dialogue.text = swanNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= swanNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < swanNarrationArray.Length - 1)
                    {

                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isSwan = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }

            }
        }

    }
    private void TwinsNarration()
    {
        if (isTwin)
        {
            txt_Dialogue.text = twinsNarrationArray[narrationstep];

            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                if (narrationstep <= twinsNarrationArray.Length)
                {
                    timer = 0;

                    if (narrationstep < twinsNarrationArray.Length - 1)
                    {
                        narrationstep++;
                        Debug.Log(narrationstep);
                    }
                    else
                    {
                        isTwin = false;

                        narrationstep = 0;
                        timer = 0;

                        SetActiveState(false);
                    }
                }
            }
        }
    }
}