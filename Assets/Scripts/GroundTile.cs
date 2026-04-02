using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    ObstacleSpawner spawner;
    CoinSpawner coinSpawner;

    void Start()
    {
        groundSpawner = FindFirstObjectByType<GroundSpawner>();
        spawner = FindFirstObjectByType<ObstacleSpawner>();
        coinSpawner= FindFirstObjectByType<CoinSpawner>();

        spawner.SpawnRow(transform);
        coinSpawner.SpawnCoins(transform);
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Trigger Exit Happened");
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Player exited tile");
    //        groundSpawner.SpawnTile();

    //        //  destroys tile + all obstacles
    //        Destroy(gameObject, 2f);
    //    }
    //}
}