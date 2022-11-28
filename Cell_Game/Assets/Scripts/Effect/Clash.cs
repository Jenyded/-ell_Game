using UnityEngine;

public abstract class Clash : EffectCollision
{
    [SerializeField] protected GameObject _effect;
    /// <summary>
    /// При столкновении проверяет Тег и вызывает метод EnableЕffect();  
    /// </summary>
    /// <param name="tag"></param>
    public abstract void ClashCollisionWithObject(string tag);
    /// <summary>
    /// Запускает эффект
    /// </summary>
    public abstract void EnableEffect();


    private void Start()
    {
        collision += ClashCollision;
    }
    /// <summary>
    /// При событии столкновения получает Тег объекта и вызывает метод ClashCollisionWithObject(tag)
    /// </summary>
    /// <param name="tag"></param>
    public void ClashCollision(string tag)
    {
        ClashCollisionWithObject(tag);
    }

    private void OnDestroy()
    {
        collision -= ClashCollision;
    }
}
