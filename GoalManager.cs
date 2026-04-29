using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public LevelManager levelManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            levelManager.NextLevel();
        }
    }
}
