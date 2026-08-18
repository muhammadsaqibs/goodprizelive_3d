using UnityEngine;

public class FielderAnimationController : MonoBehaviour
{
    public Animator animator;

    public void Ready() => Set("Ready");
    public void Sprint() => Set("Sprint");
    public void Pickup() => Set("Pickup");
    public void Throw() => Set("Throw");
    public void Catch() => Set("Catch");
    public void Miss() => Set("Miss");

    void Set(string state)
    {
        if (animator != null) animator.Play(state);
    }
}
