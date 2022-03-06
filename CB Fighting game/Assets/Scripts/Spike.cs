using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int damage;

    private Shake shake;

    public ParticleSystem SpikeDamage;
    // Start is called before the first frame update
    void Start()
    {
        SpikeDamage = GameObject.FindWithTag("damageparticles").GetComponent<ParticleSystem>();
        if(PlayerPrefs.GetInt("spikedamage") <= 0)
        {
            PlayerPrefs.SetInt("spikedamage", 20);
        }
        damage = PlayerPrefs.GetInt("spikedamage");
        shake = GameObject.FindGameObjectWithTag("screenshake").GetComponent<Shake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SpikeDamage.Play();
            collision.gameObject.GetComponent<PlayerHealth>().decreaseHealth(damage);
            shake.CamShake();
        }
    }
}
