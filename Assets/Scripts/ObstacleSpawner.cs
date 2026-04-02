using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float[] lanes = { -3f, 0f, 3f };

    public int obstaclesPerTile = 5;
    public float rowSpacing = 6f; // distance between rows

    public void SpawnRow(Transform tile)
    {
        float startZ = tile.position.z + 5f;

        for (int i = 0; i < obstaclesPerTile; i++)
        {
            //  Skip some rows randomly (for better look)
            if (Random.value < 0.3f) continue;

            int laneIndex = Random.Range(0, lanes.Length);
            float x = lanes[laneIndex];

            float z = startZ + (i * rowSpacing);

            Vector3 spawnPos = new Vector3(x, 0.5f, z);

            GameObject obs = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);

            //  Attach to tile
            obs.transform.SetParent(tile);
        }
    }
}