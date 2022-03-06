using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //public Animator camAnim;
    public int scoreOnDeath;
    public int health;

    public int rnd;
    public GameObject mechanics;
    public GameObject deathEffect;
    public ParticleSystem damageParticles;
    public GameObject clay;

    //public GameObject explosion;
    private void Start()
    {
        if (PlayerPrefs.GetInt("strength") < 100)
        {
            PlayerPrefs.SetInt("strength", 100);
        }
        mechanics = GameObject.Find("Mechanics");
    }

    private void Update()
    {
            health -= PlayerPrefs.GetInt("enemyPredamage");
        if (health <= 0)
        {
            mechanics.GetComponent<Score>().increaseScore(scoreOnDeath);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            rnd = Random.Range(0, 20);
            if(rnd == 1) {
            Instantiate(clay, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        //camAnim.SetTrigger("shake");
        //Instantiate(explosion, transform.position, Quaternion.identity);
        Instantiate(damageParticles, transform.position, Quaternion.identity);
        health -= (damage * (PlayerPrefs.GetInt("strength") / 100));
    }
}