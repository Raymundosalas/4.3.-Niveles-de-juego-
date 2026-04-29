using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform levelParent;

    public int currentLevel = 1;
    public int basePlatforms = 5;

    void Start()
    {
        GenerateLevel();
    }

    public void GenerateLevel()
    {
        ClearLevel();

        int totalPlatforms = basePlatforms + currentLevel;

        for (int i = 0; i < totalPlatforms; i++)
        {
            Vector3 pos = new Vector3(0, -i * 2.5f, 0);

            GameObject platform = Instantiate(platformPrefab, pos, Quaternion.identity, levelParent);

            float randomRotation = Random.Range(0f, 360f);
            platform.transform.Rotate(0, randomRotation, 0);

            PlatformController pc = platform.GetComponent<PlatformController>();

            if (pc != null)
            {
                pc.SetDifficulty(currentLevel);
            }
        }
    }

    void ClearLevel()
    {
        foreach (Transform child in levelParent)
        {
            Destroy(child.gameObject);
        }
    }

    public void NextLevel()
    {
        currentLevel++;
        GenerateLevel();
    }
}
