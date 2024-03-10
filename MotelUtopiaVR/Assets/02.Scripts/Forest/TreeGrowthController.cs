using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowthController : MonoBehaviour
{
    public Material treeMaterial; // 나무 Material
    private float growthFactor = 0f; // 현재 성장 정도 (0에서 1 사이)
    public float growthSpeed = 0.005f; // 성장 속도 조절, 매 프레임마다 적용될 값

    private void Update()
    {
        // 나무가 최대 성장치에 도달하지 않았다면 성장
        if (growthFactor < 1f)
        {
            growthFactor += growthSpeed * Time.deltaTime; // 성장 속도를 프레임 레이트에 독립적으로 조절
            treeMaterial.SetFloat("_GrowthFactor", growthFactor);
        }
    }
}

