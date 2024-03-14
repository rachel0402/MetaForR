using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader_last_leaf : MonoBehaviour
{
    public float minValue;
    public float maxValue;
    private float getValue;
    public float last_leaf;

    public float speed = 1f;

    public Material Set;
    public Material Chage;

    public GameObject Parents;

    // Start is called before the first frame update
    void Start()
    {
        getValue = maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (last_leaf > 0)
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
            GetComponentInParent<Selet>().Gravity.useGravity = false;
            gameObject.SetActive(false);

            getValue = maxValue;
            Chage.SetFloat("_Value", getValue);
            gameObject.GetComponent<MeshRenderer>().material = Set;
            last_leaf = 0;

            Parents = transform.parent.gameObject;
            Parents.transform.localPosition = GetComponentInParent<Grow>().Fix_position;
            Parents.transform.localEulerAngles = GetComponentInParent<Grow>().Fix_Rotation;
        }
       
    }
}
