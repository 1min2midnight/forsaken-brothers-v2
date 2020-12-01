using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed = 3;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, target.transform.position) < 4)
            transform.position = Vector2.MoveTowards(transform.position,   target.position, speed * Time.deltaTime);

    }
}