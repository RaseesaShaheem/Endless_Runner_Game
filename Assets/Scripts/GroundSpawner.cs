using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;

    private Vector3 nextSpawnPoint;

    public float tileLength = 30f;
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            SpawnTile();
        }
        //SpawnTile();
    }
    public void SpawnTile()
    {


        GameObject tile = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = tile.transform.GetChild(0).position; //chile of groundtile gameobject position, there spawning should be done.
    }
}
