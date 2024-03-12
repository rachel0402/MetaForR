using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public Button quitButton;
    public Button lobbySceneButton;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChange(); });

        quitButton.onClick.AddListener(delegate { OnQuitClick(); });

        lobbySceneButton.onClick.AddListener(delegate { OnSceneClick(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnVolumeChange()
    {
        AudioListener.volume = volumeSlider.value;
    }

    void OnQuitClick()
    {
        // Quit the application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    void OnSceneClick()
    {
        FindObjectOfType<SceneFader>().LoadScene("Lobby");
    }
}
