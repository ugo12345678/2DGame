using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigChampBehaviour : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public Collider2D player_body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.velocity = new Vector2(1, Rigidbody.velocity.y);

        if (Rigidbody.IsTouching(player_body))
        {
            GameManager.Instance.UpPlayer();
            Destroy(gameObject);
        }
    }
}
