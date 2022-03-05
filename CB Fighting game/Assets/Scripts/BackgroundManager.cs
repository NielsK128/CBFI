using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject[] backgrounds;
    void Start()
    {
        backgrounds = GameObject.FindGameObjectsWithTag("background");
        backgrounds[Random.Range(0, backgrounds.Length)].GetComponent<SpriteRenderer>().enabled = true;
    }

}
