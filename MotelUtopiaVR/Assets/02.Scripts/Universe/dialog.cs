using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�̷��� ¥�� �ȵʴϴ�...�Ф� �ð��� ���...

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


        startNarrationArray[0] = "ȯ���մϴ� �� ���� Connection Room �Դϴ�";
        startNarrationArray[1] = "Connection Room ������ ���ڸ��� �����ϸ� �޽��� ���� �� �ֽ��ϴ�. ���ڸ��� �ϳ��� �մٺ��� ��Ÿ��� ���ְ� �ϼ��˴ϴ�. �� ���ڸ��� ���� �ǹ̿� �̾߱⿡ �� ����̸� ��ȭ�ο� �ð� �����ñ� �ٶ��ϴ�.";
        startNarrationArray[2] = "�տ� ���̴� ������� �ѷ����� �������� �̵��ϸ� 4������ ���� ���ڸ����� �� �� �ֽ��ϴ�. ����� ���� ���ڸ��� �����غ�����.";

        hintNarrationArray[0] = "�� ��Ʈ���� ���� ���, �̸�, ��⸦ �����ϸ� ���� ���� ������ �����Ͽ� ���ڸ��� �ϼ��ϴ� �� ������ �ݴϴ�";
        hintNarrationArray[1] = "â�� �ۿ� ���̴� ������ �����ϰ� ��Ʈ���� ������ �������� ���� ���� ������ ���ʷ� �������ּ���";

        andromedaNarrationArray[0] = "�����մϴ�! �ȵ�θ޴� �ڸ��� �ϼ��߽��ϴ�. �ϼ��� ���ڸ��� ������ �����̼� ����ʹٸ� ����� �ѷ�������.";

        lionNarrationArray[0] = "�����մϴ�! �����ڸ��� �ϼ��߽��ϴ�. �ϼ��� ���ڸ��� ������ �����̼� ����ʹٸ� ����� �ѷ�������.";

        swanNarrationArray[0] = "�����մϴ�! �����ڸ��� �ϼ��߽��ϴ�. �ϼ��� ���ڸ��� ������ �����̼� ����ʹٸ� ����� �ѷ�������.";

        twinsNarrationArray[0] = "�����մϴ�! �ֵ����ڸ��� �ϼ��߽��ϴ�. �ϼ��� ���ڸ��� ������ �����̼� ����ʹٸ� ����� �ѷ�������.";
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