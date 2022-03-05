using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CosmeticShopItem : MonoBehaviour
{
    [SerializeField] private CosmeticManager cosmeticManager;
    [SerializeField] private int cosmeticIndex;
    [SerializeField] private Button buyButton;
    [SerializeField] private Button equipButton;
    [SerializeField] private TMP_Text costText;
    private Cosmetic cosmetic;

    void Start()
    {
        cosmetic = cosmeticManager.cosmetics[cosmeticIndex];

        if (cosmeticManager.IsUnlocked(cosmeticIndex))
        {
            buyButton.gameObject.SetActive(false);
            equipButton.gameObject.SetActive(true);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            equipButton.gameObject.SetActive(false);
            costText.text = "COST: " + cosmetic.cost.ToString();
        }
    }

    public void OnCosmeticPressed()
    {
        if (cosmeticManager.IsUnlocked(cosmeticIndex))
        {
            cosmeticManager.SelectCosmetic(cosmeticIndex);
        }
    }

    public void OnBuyButtonPressed()
    {
        int coins = PlayerPrefs.GetInt("coins");

        // Unlock the skin
        if (coins >= cosmetic.cost && !cosmeticManager.IsUnlocked(cosmeticIndex))
        {
            PlayerPrefs.SetInt("coins", coins - cosmetic.cost);
            cosmeticManager.Unlock(cosmeticIndex);
            buyButton.gameObject.SetActive(false);
            equipButton.gameObject.SetActive(true);
            cosmeticManager.SelectCosmetic(cosmeticIndex);
        }
        else
        {
            Debug.Log("Not enough coins :(");
        }
    }
}