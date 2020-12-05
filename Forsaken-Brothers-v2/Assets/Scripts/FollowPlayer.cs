using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
    public Transform player;
{
    public float speed = 3;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Debug.Log(direction);
        if (Vector2.Distance(transform.position, target.transform.position) < 4)
            transform.position = Vector2.MoveTowards(transform.position,   target.position, speed * Time.deltaTime);

    }
}