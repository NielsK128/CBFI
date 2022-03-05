using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrate : MonoBehaviour
{
    public int health;
    void Start()
    {
        
    }

    void Update()
    {
        if(health <= 0) {
            Destroy(this.gameObject);
        }
    }

        public void TakeDamage(int damage)
    {
        //camAnim.SetTrigger("shake");
        //Instantiate(explosion, transform.position, Quaternion.identity);
        //health -= (damage * (PlayerPrefs.GetInt("strength") / 100));
        health -= damage;
    }
}
