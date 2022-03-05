using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    public float scale;

    public static bool facingRight = true;


    private void Update()
    {
        Vector3 theScale = transform.localScale;
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        float WorldXPos = Camera.main.ScreenToWorldPoint(pos).x;

        if (WorldXPos > gameObject.transform.position.x)
        {
            theScale.x = -scale;
            transform.localScale = theScale;
        }
        else
        {
            theScale.x = scale;
            transform.localScale = theScale;
        }


    }
}
