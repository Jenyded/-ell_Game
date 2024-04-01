using UnityEngine;
using DG.Tweening;


public class DoTweenWindow : MonoBehaviour
{
    //private Tween _tween;
    public RectTransform RectTransform;
    

    public Sequence AnimationInPopups()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(RectTransform.DOMove(new Vector2(-0.1f, -164f), 1f).SetEase(Ease.Linear));
        sequence.Append(RectTransform.DOAnchorMax(new Vector2(5000f, 7000f), 1f));
        
       // sequence.Append(RectTransform.DOAnchorPos(new Vector2(-2.27f, 1370f), 1.5f));
        //sequence.Join(RectTransform.DOAnchorPos(new Vector2(-2.27f, 1370f), 1.5f).SetDelay(1.5f)); //SetDelay(1.5f) - задержка ждя срабатывания вместе с анимацией 2
        return sequence;
        //_tween.Kill();
        //_tween = RectTransform.DOLocalMove(new Vector3(-2.27f, 137f, 0), 1.5f); //!!!!
    }
}
