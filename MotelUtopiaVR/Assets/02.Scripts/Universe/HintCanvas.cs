using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HintCanvas : MonoBehaviour
{
    [SerializeField]
    GameObject frame;

    [SerializeField]
    List<Sprite> hintSpriteList = new List<Sprite>();
    
    [SerializeField]
    Image hintImage;

    [SerializeField]
    UnityEvent activeEvent;
    [SerializeField]
    UnityEvent deactiveEvent;

    public void Active()
    {
        SetFrameActive(true);
        activeEvent?.Invoke();
    }
    public void Deactive()
    {
        deactiveEvent?.Invoke();
    }
    public void SetFrameActive(bool state)
    {
        frame.SetActive(state);
    }
    public void SetAndromedaImage()
    {
        hintImage.sprite = hintSpriteList[0];
    }
    public void SetLionImage()
    {
        hintImage.sprite = hintSpriteList[1];
    }
    public void SetSwanImage()
    {
        hintImage.sprite = hintSpriteList[2];
    }
    public void SetTwinsImage()
    {
        hintImage.sprite = hintSpriteList[3];
    }

}
