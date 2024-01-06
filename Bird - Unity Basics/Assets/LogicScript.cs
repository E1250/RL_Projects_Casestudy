using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // now you can access the text filed in the UI
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;// Reference to game over screen.

    // public void, to control it from other c++ files
    // ContextMenu, now you can control the function from the 3dots of the logic script in the editor.
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
