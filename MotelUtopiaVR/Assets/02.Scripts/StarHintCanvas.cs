using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class StarHintCanvas : MonoBehaviour
{
    [SerializeField]
    List<Sprite> hintSpriteList = new List<Sprite>();

    [SerializeField]
    Image hintImage;

    [SerializeField]
    GameObject frame;

    [SerializeField]
    UnityEvent activeEvent;
    [SerializeField]
    UnityEvent deactiveEvent;
    private void SetActiveState(bool state)
    {
        frame.SetActive(state);
    }
    public void Active()
    {
        SetActiveState(true);
        activeEvent?.Invoke();
    }
    public void Deactive()
    {
        SetActiveState(false);
        deactiveEvent?.Invoke();
    }
    public void SetAndromedaHintImage()
    {
        //sprite에 따라서 이미지 넣기 (임시임) 
        hintImage.sprite = hintSpriteList[0];
    }
  
    public void SetLionHintImage()
    {
        //sprite에 따라서 이미지 넣기 (임시임) 
        hintImage.sprite = hintSpriteList[1];
    }
    public void SetSwanHintImage()
    {
        //sprite에 따라서 이미지 넣기 (임시임) 
        hintImage.sprite = hintSpriteList[2];
    }
    public void SetTwinsHintImage()
    {
        //sprite에 따라서 이미지 넣기 (임시임) 
        hintImage.sprite = hintSpriteList[3];
    }
}
