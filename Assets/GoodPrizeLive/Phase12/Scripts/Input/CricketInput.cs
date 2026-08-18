using UnityEngine;

public class CricketInput : MonoBehaviour
{
    public void Swing()
    {
        Debug.Log("BAT: Swing");
    }

    public void Defend()
    {
        Debug.Log("BAT: Defend");
    }

    public void Run()
    {
        Debug.Log("RUN");
    }

    public void Bowl()
    {
        Debug.Log("BOWL");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Swing();
        if (Input.GetKeyDown(KeyCode.D)) Defend();
        if (Input.GetKeyDown(KeyCode.R)) Run();
        if (Input.GetKeyDown(KeyCode.B)) Bowl();
    }
}
