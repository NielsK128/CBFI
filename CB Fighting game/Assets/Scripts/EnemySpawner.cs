using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;
    public GameObject mechanics;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnpoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(mechanics.GetComponent<Score>().getScore() >= 10+i) {
            i += 100;
            int j = (int)Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[j].transform.position, spawnPoints[j].transform.rotation);
        } 
    }
}
