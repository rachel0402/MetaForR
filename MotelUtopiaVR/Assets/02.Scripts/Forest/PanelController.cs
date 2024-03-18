using System.Collections;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject welcomePanel; 
    public GameObject tutorialPanel;
    public GameObject logoPanel;

   
    void Start()
    {
        
        tutorialPanel.SetActive(false);

        
        welcomePanel.SetActive(true);

        
        StartCoroutine(ActivateTutorialPanelAfterWelcome());
    }

    IEnumerator ActivateTutorialPanelAfterWelcome()
    {
        
        yield return new WaitForSeconds(3f);

       
        welcomePanel.SetActive(false);

        
        tutorialPanel.SetActive(true);

        
        yield return new WaitForSeconds(6f);

        
        tutorialPanel.SetActive(false);
        logoPanel.SetActive(false);
    }
}
