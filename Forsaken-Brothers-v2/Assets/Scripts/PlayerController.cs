using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D myRB;

    [SerializeField]
    private float speed;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        myRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;

        Debug.Log(myRB.velocity);
    }
}
