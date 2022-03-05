using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Weapon : MonoBehaviour
{
    public float scale;

    public int damage;

    public float rightoffset;
    public float leftoffset;

    public static bool facingRight = true;

    public GameObject projectile;
  //  public GameObject shotEffect;
    public Transform shotPoint;
  //  public Animator camAnim;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Start()
    {
    }
    private void Update()
    {
        Vector3 theScale = transform.localScale;
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        float WorldXPos = Camera.main.ScreenToWorldPoint(pos).x;

        if (WorldXPos > gameObject.transform.position.x)
        {
            theScale.y = -scale;
            transform.localScale = theScale;
        }
        else
        {
            theScale.y = scale;
            transform.localScale = theScale;
        }
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        if (facingRight == true)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rightoffset);
        } else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + leftoffset);
        }

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject()) //checks whether the mouse is clicking a button or sth
                {
                    //       Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                    //       camAnim.SetTrigger("shake");
                    Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
    public int getDamage()
    {
        return damage;
    }
}