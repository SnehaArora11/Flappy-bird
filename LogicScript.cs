using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
    //takes care of information such as score
    //also stores varies meta information

{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    //to run this function from unity itself
    [ContextMenu("Increase Score")]
    public void addScore( int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
