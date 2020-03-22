using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_platform : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
 
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
            rb.isKinematic = false;
    }

    void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        Debug.Log("You are dead");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
