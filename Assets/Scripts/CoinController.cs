using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float rotationSpeed = 200f;
    public int coinValue = 1;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Optional: add score
            //FindObjectOfType<GameManager>().AddScore(1);
            GameManager.instance.AddScore(coinValue);
            // Destroy coin
            Destroy(gameObject);
        }
    }
}

