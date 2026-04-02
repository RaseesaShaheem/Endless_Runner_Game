using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TMP_Text gameOverText;
    public Button restartButton;

   
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        StartCoroutine(GameOverSequence());
    }

    IEnumerator GameOverSequence()
    {
        gameOverText.gameObject.SetActive(true);

        yield return new WaitForSecondsRealtime(2f);

        //gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
    }
}
