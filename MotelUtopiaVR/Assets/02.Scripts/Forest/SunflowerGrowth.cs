using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerGrowth : MonoBehaviour
{
    public GameObject sunflowerSeed; // 소켓에 넣을 SunflowerSeed 오브젝트
    public GameObject sunflower; // 성장할 Sunflower 오브젝트
    private bool isSeedPlanted = false;
    private float growthRate = 0.1f;
    private float growthTime;
    private float currentGrowthTime = 0f;
    private int leafCount;
    private GameObject[] leaves;
    private Vector3[] originalLeafSizes;

    void Start()
    {
        sunflower.SetActive(false); // 초기에 Sunflower 오브젝트를 비활성화
        leafCount = sunflower.transform.childCount;
        leaves = new GameObject[leafCount];
        originalLeafSizes = new Vector3[leafCount];

        // 각 잎의 원래 크기와 비활성화 상태를 초기화
        for (int i = 0; i < leafCount; i++)
        {
            leaves[i] = sunflower.transform.GetChild(i).gameObject;
            originalLeafSizes[i] = leaves[i].transform.localScale;
            leaves[i].SetActive(false);
        }

        growthTime = leafCount * 10; // 전체 성장 시간 설정
    }

    void Update()
    {
        // 씨앗이 심어지면 성장 과정 시작
        if (isSeedPlanted)
        {
            GrowSunflower();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // SunflowerSeed가 소켓에 들어오면 실행
        if (other.gameObject == sunflowerSeed)
        {
            isSeedPlanted = true;
            sunflower.SetActive(true); // Sunflower 오브젝트 활성화
        }
    }

    void GrowSunflower()
    {
        currentGrowthTime += Time.deltaTime;
        if (currentGrowthTime <= growthTime)
        {
            int index = (int)(currentGrowthTime / 10);
            if (index < leafCount)
            {
                GameObject currentLeaf = leaves[index];
                if (!currentLeaf.activeSelf)
                    currentLeaf.SetActive(true);

                float growthProgress = (currentGrowthTime % 10) * growthRate;
                Vector3 newSize = originalLeafSizes[index] * growthProgress;
                currentLeaf.transform.localScale = newSize;
            }
        }
    }
}

