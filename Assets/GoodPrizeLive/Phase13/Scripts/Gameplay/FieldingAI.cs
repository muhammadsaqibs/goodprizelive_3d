using UnityEngine;

public class FieldingAI : MonoBehaviour
{
    public FieldingState State { get; private set; } = FieldingState.Ready;

    public void ReactToBall(Vector3 predictedPoint)
    {
        State = FieldingState.Chasing;
        Debug.Log($"Fielder chasing predicted point {predictedPoint}");
    }

    public void CompleteCatch(bool successful)
    {
        State = successful ? FieldingState.Caught : FieldingState.Missed;
    }
}

public enum FieldingState { Ready, Chasing, Caught, Missed }
