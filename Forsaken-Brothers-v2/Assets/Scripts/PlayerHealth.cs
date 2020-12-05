using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public int health;

  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health -= 10;
           

        }


        //------- use for pickups and enemies
        //if (other.CompareTag("Bbullet"))
        //{
        //    health -= 35;
        //    Destroy(other.gameObject);

        //}

        //if (other.CompareTag("HealthPickup"))
        //{
        //    health += 50;
        //    Destroy(other.gameObject);

        //}
    }
    public int getHealth()
    {
        return health;
    }
    private void Update()
    {
        if (health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

}

