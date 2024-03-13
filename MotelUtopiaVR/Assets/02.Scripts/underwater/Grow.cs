using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    private int Leaf_count;
    GameObject[] Leaves;
    private float[] Leaves_size;
    public float time;
    public float size;
    public float growthRate = 0.07f;
    private float growthTime;

    GameObject Fix;
    public Vector3 Fix_position;
    public Vector3 Fix_Rotation;
    // Start is called before the first frame update
    void Start()
    {
        Leaf_count = transform.childCount;
        growthTime = Leaf_count * 10;
        Leaves = new GameObject[Leaf_count];
        Leaves_size = new float[Leaf_count];

        for (int i = 0; i < Leaf_count; i++)
        {
            if (i == Leaf_count - 1)
            {
                Fix = transform.GetChild(i).gameObject;
                Fix_position = Fix.transform.localPosition;
                Fix_Rotation = Fix.transform.localEulerAngles;

                Leaves[i] = transform.GetChild(i).GetChild(1).gameObject;
                Leaves_size[i] = transform.GetChild(i).GetChild(1).transform.localScale.x;
                Leaves[i].SetActive(false);
            }
            else
            {
                Leaves[i] = transform.GetChild(i).gameObject;
                Leaves_size[i] = transform.GetChild(i).transform.localScale.x;
                Leaves[i].SetActive(false);
            }
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

            size = (Leaves_size[index]) * (time % 10) * growthRate;
            currentLeaf.transform.localScale = new Vector3(size, size, size);

            if(index == Leaf_count - 1)
            {
                Fix.transform.localPosition = Fix_position;
            }
        }
    }

    void clock()
    {
        if (time <= growthTime && time > -1)
        {
            time += Time.deltaTime;

            if (time % 10 == 0)
            {
                size = 0f;
            }
        }
    }

}