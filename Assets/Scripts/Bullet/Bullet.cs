using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int directionY;
    public float speedY;
    private Rigidbody2D _compRigidbody2D;
    
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0, speedY * directionY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {           
            Destroy(this.gameObject);         
        }
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }
    }
}
