using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControl : MonoBehaviour
{
    public float speedX;
    public int directionX;
    public float speedY;
    public int directionY;
    public GameObject bulletPrefab;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _compSpriteRenderer;
    private float horizontal;
    private float vertical;
    private Animator _compAnimator;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
        _compAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        if (horizontal != 0)
        {
            _compAnimator.SetBool("IsMoving", true);
        }
        else
        {
            _compAnimator.SetBool("IsMoving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(horizontal * speedX, vertical * speedY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "VerticalWall")
        {
            if (directionX == 1)
            {
                directionX = -1;

                _compSpriteRenderer.flipX = true;
            }
            else if (directionX == -1)
            {
                directionX = 1;

                _compSpriteRenderer.flipX = false;
            }
        }
        if (collision.gameObject.tag == "HorizontalWall")
        {
            if (directionY == 1)
            {

                directionY = -1;
                _compSpriteRenderer.flipY = true;
            }
            else if (directionY == -1)
            {

                directionY = 1;
                _compSpriteRenderer.flipY = false;
            }
        }
    }
}

