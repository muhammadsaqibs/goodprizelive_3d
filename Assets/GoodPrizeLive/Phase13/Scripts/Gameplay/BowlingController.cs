using UnityEngine;

public class BowlingController : MonoBehaviour
{
    public float deliverySpeed = 30f;
    public float line = 0f;
    public float length = 0.5f;

    public void SetLine(float value) => line = Mathf.Clamp(value, -1f, 1f);
    public void SetLength(float value) => length = Mathf.Clamp01(value);

    public void Bowl()
    {
        Debug.Log($"BOWL line={line:0.00} length={length:0.00} speed={deliverySpeed:0.0}");
    }
}
