using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public void enableGameOverMenu() {
        gameOverMenu.SetActive(true);
    }
}
