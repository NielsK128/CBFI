using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBooster : MonoBehaviour
{
    public int healthIncrease;
    public ParticleSystem healingParticles;
    public GameObject parentObject;
    // Start is called before the first frame update
    void Start()
    {
        healingParticles = GameObject.Find("HealingParticles").GetComponent<ParticleSystem>();
        healthIncrease = 20 + PlayerPrefs.GetInt("healthbooster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().increaseHealth(healthIncrease);
            healingParticles.Play();
            Destroy(parentObject);
            GameObject.Find("Mechanics").GetComponent<HealthBoosterSpawner>().spawnHealthBooster();
        }
    }
}
