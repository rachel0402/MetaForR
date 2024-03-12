using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_plant : MonoBehaviour
{
    public GameObject doorObject;
    Animator doorAnim;
    private bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = doorObject.GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 controllerRotation = transform.rotation.eulerAngles;

        float rotationThreshold = 18f;

        if(controllerRotation.z >= rotationThreshold && !doorOpen)
        {
            doorAnim.SetBool("Open", true);
            doorOpen = true;
            Invoke("ChangeScene", 5f);
        }

        else if(controllerRotation.z < rotationThreshold && !doorOpen)
        {
            doorAnim.SetBool("Open", false);
            doorOpen = false;
        }
    }

    //void OnTriggerEnter(Collider n)
    //{
    //    if (n.gameObject.CompareTag("key_p"))
    //    {
    //        //doorObject.transform.Rotate(new Vector3(0,0,0));
    //        doorAnim.SetTrigger("Open");
    //        Invoke("ChangeScene", 2f);
    //    }
    //}

    void ChangeScene()
    {
        SceneManager.LoadScene("Plants");
    }
    
}
