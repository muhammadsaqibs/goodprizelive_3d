using UnityEngine;

public class MobileHUD : MonoBehaviour
{
    public void OnSwing() => Debug.Log("Mobile: Swing");
    public void OnDefend() => Debug.Log("Mobile: Defend");
    public void OnRun() => Debug.Log("Mobile: Run");
    public void OnBowl() => Debug.Log("Mobile: Bowl");
    public void OnField() => Debug.Log("Mobile: Field");
}
