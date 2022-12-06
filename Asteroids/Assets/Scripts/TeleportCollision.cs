using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCollision : MonoBehaviour
{
    [SerializeField] EdgeCollider2D topCollider;
    [SerializeField] EdgeCollider2D bottomCollider;
    [SerializeField] EdgeCollider2D leftCollider;
    [SerializeField] EdgeCollider2D rightCollider;
    [SerializeField] GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Top")
        {
            parent.transform.position = new Vector3(parent.transform.position.x, bottomCollider.transform.position.y + 0.3f);
        }
        else if (collision.gameObject.name == "Bottom")
        {
            parent.transform.position = new Vector3(parent.transform.position.x, topCollider.transform.position.y - 0.3f);
        }
        else if (collision.gameObject.name == "Left")
        {
            parent.transform.position = new Vector3(rightCollider.transform.position.x - 0.3f, parent.transform.position.y);
        }
        else if (collision.gameObject.name == "Right")
        {
            parent.transform.position = new Vector3(leftCollider.transform.position.x + 0.3f, parent.transform.position.y);
        }
    }
}
