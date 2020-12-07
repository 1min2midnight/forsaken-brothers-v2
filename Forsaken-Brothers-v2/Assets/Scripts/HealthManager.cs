using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private PlayerHealth newHealth;
    public Slider healthBar;
    void Start()
    {
        newHealth = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = newHealth.maxHealth;
        //healthBar.maxValue = newHealth.health;
        healthBar.value = newHealth.health;

    }
}

