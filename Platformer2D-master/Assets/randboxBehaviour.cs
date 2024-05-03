using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randboxBehaviour : MonoBehaviour
{
    public Collider2D box_collider;
    public Collider2D player_collider;
    public GameObject big_champi;
    // Start is called before the first frame update
    void Start()
    {
        big_champi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (box_collider.IsTouching(player_collider))
        {
            big_champi.SetActive(true);

        }
        
    }
}
