using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShake : MonoBehaviour
{
    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("screenshake").GetComponent<Shake>();
        shake.CamShake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
