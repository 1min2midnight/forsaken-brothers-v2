using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public int health;
    public int durationYellow = 5;

  

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

        if (other.CompareTag("HealthUp"))
        {
            //Destroy(gameObject);
            health += 50;
            GetComponent<SpriteRenderer>().color = Color.yellow;
            StartCoroutine(RestColorYellow());
        }
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

    private IEnumerator RestColorYellow()
    {
        yield return new WaitForSeconds(durationYellow);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}

