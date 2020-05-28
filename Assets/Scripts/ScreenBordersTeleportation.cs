using UnityEngine;
/// <summary>
/// Moves GameObject to the opposite side of the screen when it reaches screen border.
/// </summary>
public class ScreenBordersTeleportation : MonoBehaviour
{
    //использую кортеж, чтобы сделать код короче и одновременно читабельнее. 
    //короче он стал однозначно. 
    private (float Top, float Bottom, float Left, float Right) Borders;
    private void Start()
    {
        Borders = (ScreenBorders.Top, ScreenBorders.Bottom, ScreenBorders.Left, ScreenBorders.Right);
    }
    private void OnBecameInvisible()
    {
        Vector3 GameObjectPositon = gameObject.transform.position;
        if (GameObjectPositon.y > Borders.Top || GameObjectPositon.y < Borders.Bottom)
        {
            gameObject.transform.position = new Vector3(GameObjectPositon.x, -GameObjectPositon.y, 0);
        }
        else if (GameObjectPositon.x < Borders.Left || GameObjectPositon.x > Borders.Right)
        {
            gameObject.transform.position = new Vector3(-GameObjectPositon.x, GameObjectPositon.y, 0);
        }
    }
}
