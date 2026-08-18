using UnityEngine;

public class MatchEventBus : MonoBehaviour
{
    void OnEnable()
    {
        CricketMatchController.OnMatchEvent += Handle;
    }

    void OnDisable()
    {
        CricketMatchController.OnMatchEvent -= Handle;
    }

    void Handle(string eventName)
    {
        Debug.Log($"MATCH EVENT: {eventName}");
        // Connect here to commentary, crowd cards, audio, replay and TV graphics.
    }
}
