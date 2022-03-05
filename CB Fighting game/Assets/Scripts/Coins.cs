using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    private int coins;
    public TMP_Text coinText;
    void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
    }

    void Update()
    {
        coinText.text = "Coins: " + PlayerPrefs.GetInt("coins").ToString();
    }


}
