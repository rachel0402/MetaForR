using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public partial class Star : MonoBehaviour
{

    //별 순서대로 넣기
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




    //별 순서의 ACTIVE 값을 받아서 순서 체크
    List<bool> correctCheckList = new List<bool>();

    bool correctCheck = true;

    //몇번째 클릭인지 확인
    int activeIndex;


}
public partial class Star : MonoBehaviour
{
    //초기화

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
    //클릭 사운드 소스
    [SerializeField]
    private AudioSource clickSound;

    //반짝임 효과 파티클
    [SerializeField]
    private ParticleSystem sparkleEffect;
    
    public void StarCheck()
    {
        //클릭 사운드 재생
        clickSound.Play();

        //반짝임 효과 재생
        sparkleEffect.Play();

        //순서대로 클릭했다면
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
            //하나라도 FALSE를 가지고 있다면 TRUE 반환
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

    //만약 incorrect 였을때 초기화 시켜주기
    public void StarReset()
    {
        correctCheckList.Clear();

        for (int i = 0; i < starObjectList.Count; i++)
        {
            starObjectList[i].isActive = false;
        }
    }
}
