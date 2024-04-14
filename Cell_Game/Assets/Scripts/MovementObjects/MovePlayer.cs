using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    private float _lefStide = -1.5f;
    private float _rightSide = 1.495f;

    private void OnMouseDrag()
    {
        if (GamePause.instance.IsPaused)
        {
            return;
        }
        if(Player.Life >= 0)
        {
            if (FunctionsButton.Instance.IsPauseGame == false)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.x = mousePos.x > _rightSide ? _rightSide : mousePos.x;
                mousePos.x = mousePos.x < _lefStide ? _lefStide : mousePos.x;
                player.position = new Vector2(mousePos.x, player.position.y);
            }
        }        
    }
}
