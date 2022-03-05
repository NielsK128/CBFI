using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth;
    public int currentHealth;

    public GameObject mechanics;

    public TMP_Text health;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindWithTag("healthtext").GetComponent<TMP_Text>();
        if (PlayerPrefs.GetInt("health") < 100)
        {
            PlayerPrefs.SetInt("health", 100);
        }
        maxHealth = PlayerPrefs.GetInt("health");
        currentHealth = maxHealth;
        mechanics = GameObject.Find("Mechanics");
    }

    // Update is called once per frame
    void Update()
    {
        health.text = currentHealth.ToString() + "/" + maxHealth.ToString();
        if(currentHealth <= 0)
        {
            gameOver();
        }
    }
    public void increaseHealth(int increase)
    {
        if (currentHealth + increase < maxHealth)
        {
            currentHealth += increase;
        } else
        {
            currentHealth = maxHealth;
        }
    }

    public void decreaseHealth(int decrease)
    {
        currentHealth -= decrease;
    }

    public float getmaxHealth()
    {
            return maxHealth;   
    }
    public float getcurrentHealth()
    {
        return currentHealth;
    }
    public void gameOver()
    {
        mechanics.GetComponent<GameOverManager>().enableGameOverMenu();
        player.SetActive(false);
        mechanics.GetComponent<Score>().addCoins();

    }
}
