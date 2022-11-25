using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    private float _lefStide = -1.86f;
    private float _rightSide = 1.86f;

    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x = mousePos.x > _rightSide ? _rightSide : mousePos.x;
        mousePos.x = mousePos.x < _lefStide ? _lefStide : mousePos.x;
        player.position = new Vector2(mousePos.x, player.position.y);
    }
}
