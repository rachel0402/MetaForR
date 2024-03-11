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
        //sprite�� ���� �̹��� �ֱ� (�ӽ���) 
        hintImage.sprite = hintSpriteList[0];
    }
  
    public void SetLionHintImage()
    {
        //sprite�� ���� �̹��� �ֱ� (�ӽ���) 
        hintImage.sprite = hintSpriteList[1];
    }
    public void SetSwanHintImage()
    {
        //sprite�� ���� �̹��� �ֱ� (�ӽ���) 
        hintImage.sprite = hintSpriteList[2];
    }
    public void SetTwinsHintImage()
    {
        //sprite�� ���� �̹��� �ֱ� (�ӽ���) 
        hintImage.sprite = hintSpriteList[3];
    }
}
