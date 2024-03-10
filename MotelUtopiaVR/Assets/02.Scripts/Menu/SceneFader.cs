using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image fadeOutUIImage;
    public float fadeSpeed = 0.8f;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // 이 오브젝트를 씬 전환 시에도 파괴되지 않도록 함
    }

    public enum FadeDirection
    {
        In, //Alpha 1 to 0
        Out //Alpha 0 to 1
    }

    // 시작할 때 바로 페이드 인 시작
    void Start()
    {
        StartCoroutine(Fade(FadeDirection.In));
    }

    // 씬을 로드하고 페이드 아웃하기
    public void LoadScene(string sceneName)
    {
        StartCoroutine(FadeAndLoadScene(FadeDirection.Out, sceneName));
    }

    // 페이드 인/아웃 처리
    IEnumerator Fade(FadeDirection fadeDirection)
    {
        float alpha = (fadeDirection == FadeDirection.Out) ? 0 : 1;
        float fadeEndValue = (fadeDirection == FadeDirection.Out) ? 1 : 0;
        if (fadeDirection == FadeDirection.Out)
        {
            while (alpha < fadeEndValue)
            {
                SetColorImage(ref alpha, fadeDirection);
                yield return null;
            }
            fadeOutUIImage.enabled = false; // 페이드 아웃 후 이미지 비활성화
        }
        else
        {
            fadeOutUIImage.enabled = true; // 페이드 인 전 이미지 활성화
            while (alpha > fadeEndValue)
            {
                SetColorImage(ref alpha, fadeDirection);
                yield return null;
            }
        }
    }

    // 씬 로드와 함께 페이드 처리
    IEnumerator FadeAndLoadScene(FadeDirection fadeDirection, string sceneName)
    {
        yield return Fade(fadeDirection);
        SceneManager.LoadScene(sceneName);
        // 새 씬에서도 페이드 인이 작동하려면, 새 씬에도 SceneFader 오브젝트가 있어야 합니다.
    }

    // 이미지의 색상 설정
    void SetColorImage(ref float alpha, FadeDirection fadeDirection)
    {
        fadeOutUIImage.color = new Color(fadeOutUIImage.color.r, fadeOutUIImage.color.g, fadeOutUIImage.color.b, alpha);
        alpha += Time.deltaTime * (1.0f / fadeSpeed) * ((fadeDirection == FadeDirection.Out) ? 1 : -1);
    }
}

