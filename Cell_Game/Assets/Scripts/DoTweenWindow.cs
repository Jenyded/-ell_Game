using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoTweenWindow : MonoBehaviour
{
    public float FadeTime = 1f;
    public RectTransform RectTransform;
    public List<GameObject> Items = new List<GameObject>();
    private Tween _tween;

    public void PanelFadeIn()
    { 
        _tween.Kill();
        RectTransform.transform.localPosition = new Vector3(0f, -200f, 0f);
        RectTransform.DOAnchorPos(new Vector2(0f, 0f), FadeTime, false).SetEase(Ease.OutElastic);
        StartCoroutine("ItemsAnimation");
    }

    public void PanelFadeOut()
    {
        _tween.Kill();
        RectTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        RectTransform.DOAnchorPos(new Vector2(-1000f, 0f), 0.4f, false).SetEase(Ease.InOutQuint);

        //RectTransform.DOAnchorPos(new Vector2(-1000f, 0f), FadeTime, false).SetEase(Ease.InOutQuint);
    }

    IEnumerator ItemsAnimation()
    {
        foreach (var item in Items)
        {
            item.transform.localScale = Vector3.zero;
        }

        foreach (var item in Items)
        {
            item.transform.DOScale(1f, FadeTime).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(0.25f);
        }
    }

    //private Tween _tween;
    //public RectTransform RectTransform;
    // _______________________________
    /*public Sequence AnimationInPopups()
     {
       var sequence = DOTween.Sequence();
      sequence.Append(RectTransform.DOMove(new Vector2(-0.1f, -164f), 1f).SetEase(Ease.Linear));
      sequence.Append(RectTransform.DOAnchorMax(new Vector2(5000f, 7000f), 1f));
      return sequence;

      // sequence.Append(RectTransform.DOAnchorPos(new Vector2(-2.27f, 1370f), 1.5f));
      // sequence.Join(RectTransform.DOAnchorPos(new Vector2(-2.27f, 1370f), 1.5f).SetDelay(1.5f)); //SetDelay(1.5f) - задержка ждя срабатывания вместе с анимацией 2
      // ____________________________
      //_tween.Kill();
      //_tween = RectTransform.DOLocalMove(new Vector3(-2.27f, 137f, 0), 1.5f); //!!!!
     }*/
}
