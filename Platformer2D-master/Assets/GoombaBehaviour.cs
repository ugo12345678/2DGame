using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaBehaviour : MonoBehaviour
{
    public Collider2D collider_left;
    public Collider2D collider_right;
    public Rigidbody2D Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody.velocity = new Vector2(-1, Rigidbody.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if( Rigidbody.IsTouching(collider_left))
        {
            Rigidbody.velocity = new Vector2(1, Rigidbody.velocity.y);
        }
        else if (Rigidbody.IsTouching(collider_right))
        {
            Rigidbody.velocity = new Vector2(-1, Rigidbody.velocity.y);
        }
    }
}
