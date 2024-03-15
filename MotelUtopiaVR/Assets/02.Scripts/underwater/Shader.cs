using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader : MonoBehaviour
{
    private float minValue = -1;
    private float maxValue = 1;
    private float getValue;

    public float speed = 0.5f;

    public Material Set;
    public Material Chage;

    // Start is called before the first frame update
    void Start()
    {
        getValue = maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponentInParent<Grow>().time < 0)
        {
            gameObject.GetComponent<MeshRenderer>().material = Chage;
            Remove();
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = Set;
        }
    }

    private void Remove()
    {

        getValue -= speed * Time.deltaTime;
        Chage.SetFloat("_Value", getValue);

        if (getValue < minValue)
        {
            gameObject.SetActive(false);
            getValue = maxValue;
            Chage.SetFloat("_Value", getValue);
            gameObject.GetComponent<MeshRenderer>().material = Set;
        }
       
    }
}
