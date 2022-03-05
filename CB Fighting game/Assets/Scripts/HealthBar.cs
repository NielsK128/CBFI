using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = (playerHealth.getcurrentHealth() / playerHealth.getmaxHealth());
        slider.value = fillValue;
    }
}
