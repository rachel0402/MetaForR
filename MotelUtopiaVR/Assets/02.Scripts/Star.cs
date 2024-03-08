using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public partial class Star : MonoBehaviour
{

    //�� ������� �ֱ�
    [SerializeField]
    List<StarObject> starObjectList = new List<StarObject>();


    //[SerializeField]
    //UnityEvent activeEvent;
    //[SerializeField]
    //UnityEvent deactiveEvent;

    [SerializeField]
    UnityEvent correctfinishEvent;

    [SerializeField]
    UnityEvent inCorrectfinishEvent;




    //�� ������ ACTIVE ���� �޾Ƽ� ���� üũ
    List<bool> correctCheckList = new List<bool>();

    bool correctCheck = true;

    //���° Ŭ������ Ȯ��
    int activeIndex;


}
public partial class Star : MonoBehaviour
{
    //�ʱ�ȭ

    void Initialize()
    {
        correctCheckList.Clear();
        activeIndex = 0;
    }
    private void Start()
    {
        Initialize();

        for (int i = 0; i < starObjectList.Count; i++)
        {
            starObjectList[i].Initialize(this);
        }
    }
}
public partial class Star : MonoBehaviour
{
   
    
    public void StarCheck()
    {
        //������� Ŭ���ߴٸ�
        if (starObjectList[activeIndex].isActive)
        {
            Debug.Log("true");
            correctCheckList.Add(true);
        }
        else
        {
            Debug.Log("false");
            correctCheckList.Add(false);
        }

        FinishCheck();
    }

    public void FinishCheck()
    {
        if (activeIndex < starObjectList.Count)
        {
            activeIndex++;
        }

        if (activeIndex >= starObjectList.Count)
        {
            //�ϳ��� FALSE�� ������ �ִٸ� TRUE ��ȯ
            correctCheck = correctCheckList.Contains(false);

            if (correctCheck)
            {
                Debug.Log("inCorrectfinishEvent");

                inCorrectfinishEvent?.Invoke();
            }
            else
            {
                Debug.Log("correctfinishEvent");

                correctfinishEvent?.Invoke();
            }

        }
      
        Debug.Log(activeIndex);
    }

    //���� incorrect ������ �ʱ�ȭ �����ֱ�
    public void StarReset()
    {
        correctCheckList.Clear();

        for (int i = 0; i < starObjectList.Count; i++)
        {
            starObjectList[i].isActive = false;
        }
    }
}
