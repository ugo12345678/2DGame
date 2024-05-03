using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaBehaviour : MonoBehaviour
{
    public Collider2D collider_left;
    public Collider2D collider_right;
    public Collider2D player_little_feet;
    public Collider2D player_big_feet;
    public Collider2D player_little_body;
    public Collider2D player_big_body;
    public Rigidbody2D Rigidbody;
    private bool direction = true; // true = gauche & false = droite
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if( Rigidbody.IsTouching(collider_left))
        {
            direction = false;
        }
        else if (Rigidbody.IsTouching(collider_right))
        {
            direction = true;
        }
        else if (Rigidbody.IsTouching(player_little_feet) || Rigidbody.IsTouching(player_big_feet))
        {
            Destroy(gameObject);
        }
        else if (Rigidbody.IsTouching(player_little_body) || Rigidbody.IsTouching(player_big_body))
        {
            GameManager.Instance.KillPlayer();
        }

        if ( direction )
        {
            Rigidbody.velocity = new Vector2(-1, Rigidbody.velocity.y);
        }
        else if ( direction == false )
        {
            Rigidbody.velocity = new Vector2(1, Rigidbody.velocity.y);
        }
    }
}
