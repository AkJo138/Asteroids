using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(Random.Range(-4f , 4f), Random.Range(-4f , 4f));
        body.SetRotation(Random.Range(0f, 360f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
