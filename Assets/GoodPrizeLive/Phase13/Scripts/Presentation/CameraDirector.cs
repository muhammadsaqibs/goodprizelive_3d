using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    public Camera mainCamera;

    public void SetCameraMode(CameraMode mode)
    {
        Debug.Log($"Camera mode: {mode}");
    }
}

public enum CameraMode
{
    Broadcast,
    Batter,
    Bowler,
    Field,
    BoundaryReplay,
    WicketReplay,
    Celebration
}
