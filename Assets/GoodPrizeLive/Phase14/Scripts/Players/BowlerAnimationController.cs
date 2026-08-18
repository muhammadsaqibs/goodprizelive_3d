using UnityEngine;

public class BowlerAnimationController : MonoBehaviour
{
    public Animator animator;

    public void Idle() => Set("Idle");
    public void RunUp() => Set("RunUp");
    public void Delivery() => Set("Delivery");
    public void FollowThrough() => Set("FollowThrough");
    public void Celebrate() => Set("Celebrate");

    void Set(string state)
    {
        if (animator != null) animator.Play(state);
    }
}
