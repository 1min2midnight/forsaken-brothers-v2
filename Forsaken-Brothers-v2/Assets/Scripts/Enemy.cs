using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    
    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            SoundManagerScript.PlaySound("enemydead");
            Die();
        }
        
    }

    void Die()
    {
        ScoreManager.currentScore += 20;
        GameObject.Destroy(gameObject);
        Debug.Log("enemy died");

    }

}
