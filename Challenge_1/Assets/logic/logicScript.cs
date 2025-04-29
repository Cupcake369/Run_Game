using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverPanel;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore +1;
        scoreText.text = playerScore.ToString();

    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void goBack()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    [ContextMenu("gameover")]
    public void gameOver()
    {
        gameOverPanel.SetActive(true);
    }
}