using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;
    private Transform playerSpawnpoint;
    void Awake()
    {
        playerSpawnpoint = GameObject.FindWithTag("playerspawnpoint").transform;
        Instantiate(player, playerSpawnpoint.transform.position, Quaternion.identity);
    }

}
