using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    GameObject[] Leaves = new GameObject[10];
    public float time;
    public float size;
    public float growthRate = 0.07f; // ���� �ӵ�
    public float growthTime = 100f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Leaves[i] = transform.GetChild(i).gameObject;
            Leaves[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        clock();
        growing_up(time);
    }

    void growing_up(float time)
    {
        if (time >= 0 && time < growthTime)
        {
            int index = (int)(time / 10);
            GameObject currentLeaf = Leaves[index];

            if (currentLeaf.activeSelf == false)
                currentLeaf.SetActive(true);

            float initialSize = index * 0.075f; // �� ���� �ʱ� ũ�� ����
            size = initialSize + (time % 10) * growthRate; // �ʱ� ũ�⿡ ���� �ӵ��� ���Ͽ� ũ�⸦ ���
            currentLeaf.transform.localScale = new Vector3(size, size, size);
        }
    }

    void clock()
    {
        if (time <= growthTime)
        {
            time += Time.deltaTime;

            if (time % 10 == 0)
            {
                size = 0f;
            }
        }
    }

}