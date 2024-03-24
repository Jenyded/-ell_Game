using UnityEngine;
using DG.Tweening;


public class DoTween : MonoBehaviour
{
    private Tween _tween;

    public RectTransform RectTransform;

    /*private void Start()
    {
        AnimationInPopups();
    }*/

    public void AnimationInPopups()
    {
        _tween.Kill();
        _tween = RectTransform.DOLocalMove(new Vector3(-2.27f, 137f, 0), 1.5f); //!!!!
    }
}
