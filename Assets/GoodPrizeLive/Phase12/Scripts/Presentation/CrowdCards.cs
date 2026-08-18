using UnityEngine;

public class CrowdCards : MonoBehaviour
{
    public GameObject sixCard;
    public GameObject fourCard;
    public GameObject welcomeKhursheed;
    public GameObject welcomeSagheer;
    public GameObject doctorFiaz;
    public GameObject meerab;
    public GameObject horab;
    public GameObject laraib;
    public GameObject mahtoob;

    public void ShowEvent(string eventName)
    {
        if (eventName == "SIX" && sixCard) sixCard.SetActive(true);
        if (eventName == "FOUR" && fourCard) fourCard.SetActive(true);
    }
}
