using UnityEngine;
using TMPro;

public class SponsorRotation : MonoBehaviour
{
    public TMP_Text sponsorText;
    public float seconds = 5f;

    readonly string[] sponsors =
    {
        "Goodway and AMC Travel & Tourism Consultancy Pvt Ltd",
        "Skyway Indo Trading Indonesia",
        "Love Is Life Dating App and Website",
        "Goodpriz Live"
    };

    float timer;
    int index;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= seconds)
        {
            timer = 0;
            index = (index + 1) % sponsors.Length;
            if (sponsorText) sponsorText.text = sponsors[index];
        }
    }
}
