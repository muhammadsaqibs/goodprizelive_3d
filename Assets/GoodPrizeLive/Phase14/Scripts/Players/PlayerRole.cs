using UnityEngine;

public enum PlayerRole
{
    Batter,
    Bowler,
    WicketKeeper,
    Fielder,
    Umpire
}

public class PlayerRoleComponent : MonoBehaviour
{
    public PlayerRole role;
    public string playerName;
    public string teamName;
}
