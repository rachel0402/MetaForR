using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public partial class StarObject : MonoBehaviour
{
    Star star;

    public bool isActive = false;
}
public partial class StarObject : MonoBehaviour
{
    //클릭 사운드
    [SerializeField]
    private AudioSource clickSound;

    //반짝임 효과
    [SerializeField]
    private ParticleSystem sparkleEffect;

    public void Initialize(Star starValue)
    {
        star = starValue;

        clickSound = GetComponent<AudioSource>();
        sparkleEffect = GetComponent<ParticleSystem>();
    }

        public void PlayClickSound()
    {
        clickSound.Play();
    }

    public void PlaySparkleEffect()
    {
        sparkleEffect.Play();
    }

    public void StopSparkleEffect()
    {
        if (sparkleEffect != null)
        {
            sparkleEffect.Stop();
        }
        else
        {
            Debug.LogWarning("Sparkle effect is not assigned.");
        }
    }

}
public partial class StarObject : MonoBehaviour
{
    public void StarCheck()
    {
        Debug.Log("StarCheck");

        SetActiveState(true);
        //���� �����ٸ�
        star.StarCheck();
    }

    private void SetActiveState(bool state)
    {
        isActive = state;
    }

}
