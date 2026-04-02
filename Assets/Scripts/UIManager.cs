using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    void Update()
    {
        scoreText.text = "Score: " + GameManager.instance.score;
        healthText.text = "Health: " + GameManager.instance.health;
    }
}