using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    private GroundSpawner spawner;

    void Start()
    {
        spawner = FindFirstObjectByType<GroundSpawner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("SPAWN EARLY");

            spawner.SpawnTile();

            // destroy AFTER some delay
            Destroy(transform.parent.gameObject, 5f);
        }
    }
    
}
