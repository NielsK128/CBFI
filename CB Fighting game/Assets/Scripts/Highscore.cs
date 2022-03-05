using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    private int highscore;
    public TMP_Text highscoreText;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
    }

    void Update()
    {
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
