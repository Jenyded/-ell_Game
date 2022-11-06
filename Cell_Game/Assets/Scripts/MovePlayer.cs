using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;

    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x = mousePos.x > 1.86f ? 1.86f : mousePos.x;
        mousePos.x = mousePos.x < -1.86f ? -1.86f : mousePos.x;
        player.position = new Vector2(mousePos.x, player.position.y);
    }
}
