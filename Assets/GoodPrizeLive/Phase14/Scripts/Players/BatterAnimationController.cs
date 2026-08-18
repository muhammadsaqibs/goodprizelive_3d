using UnityEngine;

public class BatterAnimationController : MonoBehaviour
{
    public Animator animator;

    public void Idle() => Set("Idle");
    public void Ready() => Set("Ready");
    public void FrontFoot() => Set("FrontFoot");
    public void BackFoot() => Set("BackFoot");
    public void Defend() => Set("Defend");
    public void Sweep() => Set("Sweep");
    public void Drive() => Set("Drive");
    public void Pull() => Set("Pull");
    public void Hook() => Set("Hook");
    public void Celebrate() => Set("Celebrate");

    void Set(string state)
    {
        if (animator != null) animator.Play(state);
    }
}
