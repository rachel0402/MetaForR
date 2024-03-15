using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Move : MonoBehaviour
{
    public float Speed = 1f;
    public float Rotation_Speed = 1f;
    public int Count;
    private float x;
    private float y;
    private float z;
    private Vector3 Random_Position;
    private Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        Count = 1;
        Random_check();
        SetRotation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Count < 15)
        {
            if (Vector3.Distance(transform.localPosition, Random_Position) < 0.01f)
            {
                Random_check();
                SetRotation();
            }
            Object_Move();
            RotateObject();
        }
    }

    private void Random_check()
    {
        x = Random.Range(-8f, 8f);
        y = Random.Range(0f, 3f);
        z = Random.Range(-8f, 8f);
        Random_Position = new Vector3(x, y, z);
        Count += 1;
    }

    private void Object_Move()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, Random_Position, Speed * Time.deltaTime);
    }

    private void SetRotation()
    {
        Vector3 direction = Random_Position - transform.localPosition;
        targetRotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, -90, 0);
    }

    private void RotateObject()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Rotation_Speed * Time.deltaTime);
    }
}