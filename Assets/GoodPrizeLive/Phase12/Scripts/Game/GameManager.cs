using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public MatchPhase Phase { get; private set; } = MatchPhase.MainMenu;
    public int Runs { get; private set; }
    public int Wickets { get; private set; }
    public int LegalBalls { get; private set; }
    public int Target { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartToss() => Phase = MatchPhase.Toss;

    public void StartInnings(int target = 0)
    {
        Runs = 0; Wickets = 0; LegalBalls = 0; Target = target;
        Phase = target > 0 ? MatchPhase.InningsTwo : MatchPhase.InningsOne;
    }

    public void RecordDelivery(int runs, bool legal, bool wicket)
    {
        Runs += Mathf.Max(0, runs);
        if (legal) LegalBalls++;
        if (wicket) Wickets = Mathf.Min(10, Wickets + 1);
    }

    public float Overs => LegalBalls / 6 + (LegalBalls % 6) / 10f;
}

public enum MatchPhase
{
    MainMenu, TeamSelect, Toss, InningsOne, InningsBreak,
    InningsTwo, SuperOver, Result
}
