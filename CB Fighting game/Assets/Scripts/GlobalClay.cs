using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalClay : MonoBehaviour
{
    public static int clayCount;
    void Start()
    {
        clayCount = PlayerPrefs.GetInt("clay");
    }

    void Update()
    {
    }

    public static void addClay() {
        clayCount++;
        PlayerPrefs.SetInt("clay", clayCount);
    }

    public static int getClay() {
        return clayCount;
    }

    public static void removeClay(int i) {
        clayCount = clayCount - i;
        PlayerPrefs.SetInt("clay", clayCount);
    }
}
