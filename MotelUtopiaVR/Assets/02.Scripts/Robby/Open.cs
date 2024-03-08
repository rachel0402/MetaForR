using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject doorObject;
    Animator doorAnim;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = doorObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider n)
    {
        if (n.gameObject.CompareTag("door"))
        {
            //doorObject.transform.Rotate(new Vector3(0,0,0));
            doorAnim.SetTrigger("Open");
        }
    }
    void OnTriggerExit(Collider n)
    {
        if (n.gameObject.CompareTag("door"))
        {
            //doorObject.transform.Rotate(new Vector3(0, 90, 0));
            doorAnim.SetTrigger("Ready");
        }
    }
}
