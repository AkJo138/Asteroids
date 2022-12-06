using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float acceleration = 2f;
    [SerializeField] float angVelocity = 50f;
    [SerializeField] GameObject laser;
    
    float maxSpeed;
    float decelFactor;
    string terrainTag;
    SpriteRenderer sprite;
    Rigidbody2D body;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newLaser = Instantiate(laser, transform.position, Quaternion.Euler(0, 0, transform.eulerAngles.z + 90f));
            newLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f) * transform.up;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = moveSpeed;
        Vector2 direction = transform.up;
        if (Input.GetKey(KeyCode.W))
        {
            body.velocity += acceleration * direction;
            anim.SetTrigger("FlamesOff");
        }
        else
        {
            anim.SetTrigger("FlamesOn");
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.angularVelocity = -angVelocity;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            body.angularVelocity = angVelocity;
        }
        else
        {
            body.angularVelocity = 0;
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
