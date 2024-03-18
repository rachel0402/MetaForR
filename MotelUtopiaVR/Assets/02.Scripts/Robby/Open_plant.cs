using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_plant : MonoBehaviour
{
    public GameObject doorObject;
    private Rigidbody doorRigidbody;
    Animator doorAnim;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = doorObject.GetComponent<Animator>();
        //doorRigidbody = doorObject.GetComponent<Rigidbody>();

        //if (doorRigidbody == null)
        //{
        //    Debug.LogWarning("Rigidbody component not found on door object.");
        //}
    }

    void OnTriggerEnter(Collider n)
    {
        //doorRigidbody != null && 

        if (n.gameObject.CompareTag("key_p"))
        {
            Debug.Log("´ê¾Ò´Ï");
            //doorObject.transform.Rotate(new Vector3(0,0,0));
            doorAnim.SetTrigger("Open");
            Invoke("ChangeScene", 2f);
        }
    }

    void ChangeScene()
    {

        SceneManager.LoadScene("Forest");
    }

}
