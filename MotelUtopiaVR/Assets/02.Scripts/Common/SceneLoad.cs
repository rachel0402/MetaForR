using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("¾À·Îµå");

        GameObject.Destroy(this);
        SceneManager.LoadSceneAsync(sceneName);
    }
 
}
