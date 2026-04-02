using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public int score = 0;
    public int health = 3;
    public GameOverManager GameOverManager;


    public bool isGameOver = false;

    void Awake()
    {
        instance = this;
    }

    //  Add score only from coins
    public void AddScore(int amount)
    {
        score += amount;
    }

    //  Damage system
    public void TakeDamage(int damage)
    {
        if (isGameOver) return;

        health -= damage;
        Debug.Log("Health: " + health);

        if (health <= 0)
        {
            GameOverManager.GameOver();
        }
    }

    
}