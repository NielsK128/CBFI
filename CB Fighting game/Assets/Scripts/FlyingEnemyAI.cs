using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlyingEnemyAI : MonoBehaviour
{
    public bool playerWithinRange;
    public Transform player;
    public LayerMask playerLayerMask;
    public Transform center;
    public float radius;
    public float speed; 
    public bool facingRight = false;    
    public bool canAttack;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if(facingRight == true && player.transform.position.x < this.gameObject.transform.position.x) {
            this.gameObject.transform.Rotate(0, 180, 0);
            facingRight = false;
        } else if (facingRight == false && player.transform.position.x > this.gameObject.transform.position.x) {
            this.gameObject.transform.Rotate(0, 180, 0);
            facingRight = true;
        }
        playerWithinRange = Physics2D.OverlapCircle(center.position, radius, playerLayerMask);
        if(playerWithinRange) {
        transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
