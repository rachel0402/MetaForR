using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_space : MonoBehaviour
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
        if (n.gameObject.CompareTag("key_s"))
        {
            //doorObject.transform.Rotate(new Vector3(0,0,0));
            doorAnim.SetTrigger("Open");
            Invoke("ChangeScene", 2f);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Space");
    }
    
}
