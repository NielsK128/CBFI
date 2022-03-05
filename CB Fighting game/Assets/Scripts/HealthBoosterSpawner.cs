using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoosterSpawner : MonoBehaviour
{
    public GameObject[] CollectableSpawnPoints;
    public GameObject healthBooster;

    // Start is called before the first frame update
    void Start()
    {
        CollectableSpawnPoints = GameObject.FindGameObjectsWithTag("collectable");
        int i = (int)Random.Range(0, CollectableSpawnPoints.Length);
        Instantiate(healthBooster, CollectableSpawnPoints[i].transform.position, CollectableSpawnPoints[i].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnHealthBooster()
    {
        int i = (int)Random.Range(0, CollectableSpawnPoints.Length);
        Instantiate(healthBooster, CollectableSpawnPoints[i].transform.position, CollectableSpawnPoints[i].transform.rotation);
    }
}
