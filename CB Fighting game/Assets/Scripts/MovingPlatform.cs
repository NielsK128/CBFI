using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirX, moveSpeed = 2f;
    public float moveRange = 4f;
    bool moveRight = true;

    void Update()
    {
        if(transform.position.x > moveRange) {
            moveRight = false;
        }
        if(transform.position.x < -moveRange) {
            moveRight = true;
        }

        if(moveRight) {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        } else {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
