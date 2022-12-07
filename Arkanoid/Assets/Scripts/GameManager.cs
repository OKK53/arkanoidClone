using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text score;
    public Text won;
    public Text gameover;
    public int ArkScore { get; private set;}
    public int maxScore=65;

    public void PlayerWon()
    {
            won.enabled = true;
            Invoke("Restart", 2f);
    }

    public void Scored()
    {
        ArkScore++;
        score.text = "Score: " + ArkScore.ToString(); 
    }

    void Restart()  
    {       
        SceneManager.LoadScene("Level 1");
    }

    public void GameOver()
    {
        gameover.enabled = true;

        Invoke("Restart", 2f);
    }
}
