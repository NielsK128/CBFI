using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public static bool facingRight = true;

    public float speed = 20f;
    public float lifeTime;

    public GameObject weapon;
    public int damage;
    //public float distance;
    //public int damage;
    //public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        weapon = GameObject.FindGameObjectWithTag("weapon");
        damage = weapon.GetComponent<Weapon>().getDamage();
        speed = speed + (((PlayerPrefs.GetFloat("bulletspeed")) * speed) / 100);
        lifeTime = lifeTime + ((((PlayerPrefs.GetFloat("bulletspeed")) * lifeTime) / 100));
    }

    private void Update()
    {
 
    }
    public void FixedUpdate()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up/*, distance, whatIsSolid*/);
        //if (hitInfo.collider != null)
        //{
        //if (hitInfo.collider.CompareTag("enemy"))
        //{
        //    hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
        //}
        //DestroyProjectile();
        // }

            transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!(collision.gameObject.tag == "Player")) { 
        DestroyProjectile();
        if(collision.gameObject.tag == "enemy")
            {
                collision.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            } else if (collision.gameObject.tag == "crate") {
                collision.gameObject.GetComponent<DestroyCrate>().TakeDamage(damage);
            }
    }
    }

    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}