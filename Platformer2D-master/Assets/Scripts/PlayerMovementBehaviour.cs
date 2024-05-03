using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public Rigidbody2D Rigidbody;
    public SpriteRenderer SpriteRenderer;
    public Animator Animator;


    public LayerMask GroundMask;
    public LayerMask EnemieMask;
    public float RaycastDistance;
    public Collider2D LittleCollider;
    public Collider2D BigCollider;

    private bool _isGrounded;
    private bool _ended = false;
    private bool _isBig;

    // Start is called before the first frame update
    void Start()
    {
        BigCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = LittleCollider.IsTouchingLayers(GroundMask);

        if (Input.GetKey(KeyCode.RightArrow) && _ended == false)
        {
            SpriteRenderer.flipX = false;
  
            if (_isGrounded)
            {
                Rigidbody.velocity = new Vector2(Speed, Rigidbody.velocity.y);
                
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && _ended == false)
        {
            SpriteRenderer.flipX = true;
            if (_isGrounded)
                Rigidbody.velocity = new Vector2(-Speed, Rigidbody.velocity.y);
        }
        else
            Rigidbody.velocity = new Vector2(0, Rigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded && _ended == false)
        {
            Rigidbody.AddForce(Vector2.up * JumpForce);
            Animator.SetTrigger("Jump");
        }

        if ( transform.position.y < -1 ) 
        {
            GameManager.Instance.KillPlayer();
        }
        Animator.SetBool("IsGrounded", _isGrounded);
        Animator.SetFloat("velocityX", Mathf.Abs(Rigidbody.velocity.x));
        Animator.SetFloat("velocityY", Rigidbody.velocity.y);
        
    }
}

