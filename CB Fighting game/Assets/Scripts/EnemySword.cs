using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : MonoBehaviour
{
    public Animator swordswing;
    public int timeBtwSwings;

    public int damage; 

    public bool canAttack = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "Player") {
            StartCoroutine(Attack(col));
            canAttack = true;
        }
    }

    public void OnTriggerExit2D(Collider2D col) {
    if(col.gameObject.tag == "Player") {
        canAttack = false;
    }
    }

    IEnumerator Attack(Collider2D col) {
         swordswing.SetTrigger("Attack");
         col.gameObject.GetComponent<PlayerHealth>().decreaseHealth(damage);
         yield return new WaitForSeconds(timeBtwSwings);
         if(canAttack == true) {
         StartCoroutine(Attack(col));
        }

    }
}
