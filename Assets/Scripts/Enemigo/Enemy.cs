using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{  

    public GameObject explosionPrefab;
    private Rigidbody2D _compRigidbody;
    public float speedY;
    public float directionY;
    public GameManagerControl gameManager;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, -speedY); 
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            gameManager.UpdatePoints(10);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }

    }

    public void SetGameManager(GameManagerControl gm)
    {
        gameManager = gm;
    }
}
