
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopController : MonoBehaviour
{
    [SerializeField] private Image selectedSkin;
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private SkinManager skinManager;

    public GameObject[] selectedSkinPreviews;

    void Start() {
        selectedSkinPreviews = GameObject.FindGameObjectsWithTag("selectedskin");
    }
    void Update()
    {
        coinsText.text = "Coins: " + PlayerPrefs.GetInt("Coins");
        selectedSkin.sprite = skinManager.GetSelectedSkin().sprite;
        foreach(GameObject skin in selectedSkinPreviews) {
            skin.GetComponent<Image>().sprite = skinManager.GetSelectedSkin().sprite;
        } 
    }

    public void LoadMenu() => SceneManager.LoadScene("MainMenuScene");
}