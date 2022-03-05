using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CosmeticShopController : MonoBehaviour
{
    [SerializeField] private Image selectedCosmetic;
    [SerializeField] private CosmeticManager cosmeticManager;
 
    void Start() {
    }
    void Update()
    {
        selectedCosmetic.sprite = cosmeticManager.GetSelectedCosmetic().sprite;
    }

    public void LoadMenu() => SceneManager.LoadScene("MainMenuScene");
}
