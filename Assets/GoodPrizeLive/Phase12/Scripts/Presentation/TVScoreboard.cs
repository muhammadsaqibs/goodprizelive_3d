using UnityEngine;
using TMPro;

public class TVScoreboard : MonoBehaviour
{
    public TMP_Text teamText;
    public TMP_Text scoreText;
    public TMP_Text oversText;
    public TMP_Text targetText;

    void Update()
    {
        if (GameManager.Instance == null) return;
        var g = GameManager.Instance;
        if (scoreText) scoreText.text = $"{g.Runs}/{g.Wickets}";
        if (oversText) oversText.text = $"Overs {g.Overs:0.0}";
        if (targetText) targetText.text = g.Target > 0 ? $"Target {g.Target}" : "";
    }
}
