using UnityEngine;
/// <summary>
/// Provides screen borders coordinates for access throuthout the whole game.
/// </summary>
public static class ScreenBorders
{
    private static float ScreenCentre, HalfCamWidth;
    /// <summary>
    /// Coordinates of left screen border.
    /// </summary>
    public static float Left { get; private set; }
    /// <summary>
    /// Coordinates of right screen border.
    /// </summary>
    public static float Right { get; private set; }
    /// <summary>
    /// Coordinates of top screen border.
    /// </summary>
    public static float Top { get; private set; }
    /// <summary>
    /// Coordinates of bottom screen border.
    /// </summary>
    public static float Bottom { get; private set; }
    [RuntimeInitializeOnLoadMethod]
    private static void CalculateScreenBorders()
    {
        ScreenCentre = Camera.main.transform.position.x;
        Top = Camera.main.orthographicSize;
        Bottom = ScreenCentre - Top;
        HalfCamWidth = Top * Camera.main.aspect;
        Left = ScreenCentre - HalfCamWidth;
        Right = ScreenCentre + HalfCamWidth;
    }
}