using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    //GameOverManager gameOverManager;
    private bool hasHit = false;

    void Start()
    {
        //gameOverManager = FindFirstObjectByType<GameOverManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasHit && collision.gameObject.CompareTag("Player"))
        {
            hasHit = true;

            GameManager.instance.TakeDamage(1);

            // Optional: destroy obstacle after hit
            Destroy(gameObject);
            //gameOverManager.GameOver();
        }
    }
}