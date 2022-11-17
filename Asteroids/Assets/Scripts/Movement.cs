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
    float maxSpeed;
    float decelFactor;
    string terrainTag;
    SpriteRenderer sprite;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = moveSpeed;
        Vector2 direction = transform.up;
        if (Input.GetKey(KeyCode.W))
        {
            body.velocity += acceleration * direction;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            body.velocity += -acceleration * direction * 3 / 5;
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.AddTorque(-10);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            body.AddTorque(10);
        }
        else
        {
            body.angularVelocity = 0;
        }
    }
}
