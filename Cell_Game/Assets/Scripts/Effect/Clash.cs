using UnityEngine;

public abstract class Clash : EffectCollision
{
    [SerializeField] protected GameObject _effect;
    /// <summary>
    /// ��� ������������ ��������� ��� � �������� ����� Enable�ffect();  
    /// </summary>
    /// <param name="tag"></param>
    public abstract void ClashCollisionWithObject(string tag);
    /// <summary>
    /// ��������� ������
    /// </summary>
    public abstract void EnableEffect();


    private void Start()
    {
        collision += ClashCollision;
    }
    /// <summary>
    /// ��� ������� ������������ �������� ��� ������� � �������� ����� ClashCollisionWithObject(tag)
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
