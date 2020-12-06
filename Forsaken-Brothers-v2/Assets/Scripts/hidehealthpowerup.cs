using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidehealthpowerup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("powerupp");
            Destroy(gameObject);
        }
    }
}
