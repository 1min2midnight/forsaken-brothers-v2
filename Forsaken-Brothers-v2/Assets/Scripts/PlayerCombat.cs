using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    public int durationA = 30;
    public int durationRange = 30;

    public float attackRate = 2f;
    float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {
      
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            Debug.Log("wE hit");
        }
    
    }
   
    private void OnDrawGizmosSelected()
    {
        
        if (attackpoint == null)
            return;
        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.tag == "PowerUp")
        {
            //Debug.Log("powerup attained");
            Destroy(collision.gameObject);
            attackDamage = 55;
            GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(RestAttack());
               
        }

        if (collision.tag == "RangeUp")
        {
            Destroy(collision.gameObject);
            attackRange = 2f;
            GetComponent<SpriteRenderer>().color = Color.gray;
            StartCoroutine(RestRange());
                
        }


    }

    private IEnumerator RestAttack()
    {
        yield return new WaitForSeconds(durationA);
        attackDamage = 40;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private IEnumerator RestRange()
    {
        yield return new WaitForSeconds(durationRange);
        attackRange = 0.5f;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
