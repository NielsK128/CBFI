using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text pauseScore;
    public TMP_Text gameOverScore;
    public int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pauseScore.text = "Score: " + scoreValue.ToString();
        score.text = "Score: "+ scoreValue.ToString();
        gameOverScore.text = "Score: " + scoreValue.ToString();
        if(scoreValue > PlayerPrefs.GetInt("highscore"))
        {
            setHighscore(scoreValue);
        }
    }

    public void increaseScore(int scoreIncrease)
    {
        scoreValue += scoreIncrease;
    }

    public int getScore()
    {
        return scoreValue;
    }

    public void addCoins()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + (scoreValue / 10));
    }

    public void setHighscore(int highscore)
    {
        PlayerPrefs.SetInt("highscore", scoreValue);
    }
}
