using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatfom : MonoBehaviour
{
    public float Time = 2;
    Rigidbody2D rb;
    

    

// Start is called before the first frame update
void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject,Time);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
}

