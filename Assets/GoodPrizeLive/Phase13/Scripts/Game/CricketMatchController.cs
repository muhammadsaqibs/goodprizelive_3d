using UnityEngine;
using System;

public class CricketMatchController : MonoBehaviour
{
    public static event Action<string> OnMatchEvent;

    public void Four() => Deliver("FOUR", 4, true, false);
    public void Six() => Deliver("SIX", 6, true, false);
    public void Dot() => Deliver("DOT", 0, true, false);
    public void Wicket() => Deliver("WICKET", 0, true, true);
    public void Wide() => Deliver("WIDE", 1, false, false);
    public void NoBall() => Deliver("NO_BALL", 1, false, false);

    void Deliver(string name, int runs, bool legal, bool wicket)
    {
        if (GameManager.Instance == null) return;
        GameManager.Instance.RecordDelivery(runs, legal, wicket);
        OnMatchEvent?.Invoke(name);
    }
}
