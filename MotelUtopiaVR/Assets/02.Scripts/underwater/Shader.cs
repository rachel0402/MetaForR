using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader : MonoBehaviour
{
    public float minValue;
    public float maxValue;
    private float getValue;

    public float speed = 1f;

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
