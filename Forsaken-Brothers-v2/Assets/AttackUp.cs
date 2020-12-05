using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUp : MonoBehaviour
{
    public GameObject attackBoost;
    public int duration = 15;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            StartCoroutine(AttackItem(other));
        }

        IEnumerator AttackItem(Collider2D player)
        {

            PlayerCombat increaseA = player.GetComponent<PlayerCombat>();


            increaseA.attackDamage += 10;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            yield return new WaitForSeconds(duration);

            increaseA.attackDamage -= 10;

            Destroy(gameObject);

            //Debug.Log("You have obtain the power up");
        }
    }
}