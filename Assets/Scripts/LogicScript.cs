using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text winScore;
    public GameObject gameOverScreen;
    public GameObject scoreBoard;
    public int moveSpeed = 15;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        
        SpeedIncrease();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        winScore.text = "Score: " + playerScore.ToString();
        gameOverScreen.SetActive(true);
        scoreBoard.SetActive(false);
        // Debug.Log(playerScore);
    }
    
    public void SpeedIncrease()
    {
        moveSpeed = moveSpeed + (int)1;
    }
}
