using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    public void PlayDelivery(DeliveryEvent evt)
    {
        if (GameManager.Instance == null) return;
        GameManager.Instance.RecordDelivery(evt.runs, evt.legal, evt.wicket);
        SendMessage("OnCricketEvent", evt.eventName, SendMessageOptions.DontRequireReceiver);
    }
}

[System.Serializable]
public struct DeliveryEvent
{
    public string eventName;
    public int runs;
    public bool legal;
    public bool wicket;
}
