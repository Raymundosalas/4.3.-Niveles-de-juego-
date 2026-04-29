using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject dangerZone;

    public void SetDifficulty(int level)
    {
        int dangerChance = Mathf.Clamp(level * 10, 10, 70);

        if (Random.Range(0, 100) < dangerChance)
        {
            dangerZone.SetActive(true);
        }
        else
        {
            dangerZone.SetActive(false);
        }
    }
}
