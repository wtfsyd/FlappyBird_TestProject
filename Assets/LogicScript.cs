using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreAudio;
    public static int highScore;


    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreAudio.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        if (highScore < playerScore)
        {
            saveHighScore(playerScore);
        }
    }

    public void saveHighScore(int highscore)
    {
        PlayerPrefs.SetInt("HighScore", highscore);
    }



}
