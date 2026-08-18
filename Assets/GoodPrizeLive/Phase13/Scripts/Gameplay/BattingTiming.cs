using UnityEngine;

public class BattingTiming : MonoBehaviour
{
    [Range(0f, 1f)] public float perfectWindow = 0.18f;

    public BatResult Calculate(float timingError)
    {
        float e = Mathf.Abs(timingError);
        if (e <= perfectWindow) return BatResult.Perfect;
        if (e <= 0.40f) return BatResult.Good;
        if (e <= 0.70f) return BatResult.Edge;
        return BatResult.Miss;
    }
}

public enum BatResult { Perfect, Good, Edge, Miss }
