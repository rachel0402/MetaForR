using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerGrowth : MonoBehaviour
{
    private int Leaf_count;
    GameObject[] Leaves;
    private float[] Leaves_size;
    public float time;
    public float size;
    public float growthRate = 0.07f;
    private float growthTime;
    public GameObject sunflowerSeed; // 이 객체와 상호작용할 Seed 객체
    public GameObject sunflowerBase; // 이 객체와 상호작용할 Base 객체
    public GameObject flower;

    // Start is called before the first frame update
    void Start()
    {
        Leaf_count = transform.childCount;
        growthTime = Leaf_count * 10;
        Leaves = new GameObject[Leaf_count];
        Leaves_size = new float[Leaf_count];

        for (int i = 0; i < Leaf_count; i++)
        {
            Leaves[i] = transform.GetChild(i).gameObject;
            Leaves_size[i] = transform.GetChild(i).transform.localScale.x;
            Leaves[i].SetActive(false);
        }

        // 초기에는 Sunflower를 비활성화 상태로 만듭니다.
        gameObject.SetActive(false);

        if (flower != null)
        {
            flower.SetActive(false); // 게임 시작 시 Flower 객체도 비활성화
        }
    }

    // Update is called once per frame
    void Update()
    {
        clock();
        growing_up(time);

        if (time>=growthTime)
        {
            CompleteGrowth();
        }
    }

    void growing_up(float time)
    {
        if (time >= 0 && time < growthTime)
        {
            int index = (int)(time / 10);
            GameObject currentLeaf = Leaves[index];

            if (currentLeaf.activeSelf == false)
                currentLeaf.SetActive(true);

            size = (Leaves_size[index]) * (time % 10) * growthRate;
            currentLeaf.transform.localScale = new Vector3(size, size, size);
        }
    }

    void clock()
    {
        if (time <= growthTime && time > 0)
        {
            time += Time.deltaTime;

            if (time % 10 == 0)
            {
                size = 0f;
            }
        }
    }

    // 이 메서드는 SunflowerSeed가 Sunflowerbase에 심어질 때 호출되어야 합니다.
    public void OnSeedPlanted()
    {
        // SunflowerSeed와 Sunflowerbase를 비활성화
        sunflowerSeed.SetActive(false);
        sunflowerBase.SetActive(false);

        // Sunflower 객체 활성화 및 성장 시작
        gameObject.SetActive(true);
        time = 1f; // 성장 과정을 시작하기 위해 time을 초기화합니다.
    }

    void CompleteGrowth()
    {
        gameObject.SetActive(false); // Sunflower 객체 비활성화
        if (flower != null)
        {
            flower.SetActive(true); // Flower 객체 활성화
        }
    }
}


