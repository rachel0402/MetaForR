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

    //반짝임 효과
    //private GameObject sparkleEffectPrefabs;

    [SerializeField]
    private ParticleSystem sparkleEffect;

    public void Initialize(Star starValue)
    {
        star = starValue;
    }

 

    public void PlaySparkleEffect()
    {
        //지금 피봇이 중점이 아니라 불가능
        //GameObject instance = Instantiate(sparkleEffectPrefabs, this.transform);
        //sparkleEffect = instance.GetComponent<ParticleSystem>();

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
        PlaySparkleEffect();
        SetActiveState(true);
        star.StarCheck();
    }

    private void SetActiveState(bool state)
    {
        isActive = state;
    }

}
