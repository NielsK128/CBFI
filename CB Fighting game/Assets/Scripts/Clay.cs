using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clay : MonoBehaviour
{
    public GameObject parentObject;

    public ParticleSystem clayParticles;
    // Start is called before the first frame update
    void Start()
    {   
                clayParticles = GameObject.Find("ClayParticles").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GlobalClay.addClay();
            clayParticles.Play();
            Destroy(parentObject);
        }
    }
}
