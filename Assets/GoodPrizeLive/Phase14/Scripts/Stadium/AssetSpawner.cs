using UnityEngine;

public class AssetSpawner : MonoBehaviour
{
    public GameObject batterPrefab;
    public GameObject bowlerPrefab;
    public GameObject keeperPrefab;
    public GameObject fielderPrefab;

    public StadiumAnchors anchors;

    public void SpawnPreview()
    {
        if (anchors == null) return;

        if (batterPrefab != null && anchors.batterEnd != null)
            Instantiate(batterPrefab, anchors.batterEnd.position, anchors.batterEnd.rotation);

        if (bowlerPrefab != null && anchors.bowlerEnd != null)
            Instantiate(bowlerPrefab, anchors.bowlerEnd.position, anchors.bowlerEnd.rotation);

        if (keeperPrefab != null && anchors.keeperPosition != null)
            Instantiate(keeperPrefab, anchors.keeperPosition.position, anchors.keeperPosition.rotation);
    }
}
