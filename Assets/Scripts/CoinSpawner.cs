using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float[] lanes = { -3f, 0f, 3f };

    public int coinsPerTile = 10;
    public float spacing = 2f; // distance between coins

    public LayerMask obstacleLayer;

    public void SpawnCoins(Transform tile)
    {
        float startZ = tile.position.z + 2f;

        int spawned = 0;
        int attempts = 0;

        while (spawned < coinsPerTile && attempts < coinsPerTile * 3)
        {
            int laneIndex = Random.Range(0, lanes.Length);
            float x = lanes[laneIndex];

            float z = startZ + (spawned * spacing);

            Vector3 pos = new Vector3(x, 1f, z);

            // Check if obstacle is there
            if (!Physics.CheckSphere(pos, 0.6f, obstacleLayer))
            {
                GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);
                coin.transform.SetParent(tile);
                spawned++;
            }

            attempts++;
        }
    }
}