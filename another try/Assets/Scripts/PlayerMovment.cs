using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    private SpriteRenderer sprite = null;

    [SerializeField]
    private float speed = 4f;

    [SerializeField]
    private float jumpSpeed = 100f;

    [SerializeField]
    public Collider2D groundSensor = null;

    [SerializeField]
    public LayerMask groundLayer = 0;

    [SerializeField]
    private Joystick jStick = null;
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = speed * jStick.Horizontal;
        physicsBody.velocity = newVelocity;
    }

    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -speed;
        physicsBody.velocity = newVelocity;

        if (physicsBody.velocity.x < -0.1f)
        {
            sprite.flipX = false;
        }

    }

    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = speed;
        physicsBody.velocity = newVelocity;

        
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;

            newVelocity.y = jumpSpeed;
            physicsBody.velocity = newVelocity;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get rigidbody that we need to use to find physics
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

        //Find the speed from the rigidbody
        float currentSpeedH = Mathf.Abs(rigidBody.velocity.x);

        // get animator component that we use and set the animation
        Animator animator = GetComponent<Animator>();

        // tell animator what the speeds are
        animator.SetFloat("SpeedH", currentSpeedH);

        if (physicsBody.velocity.x < 0)
        {
            sprite.flipX = false;
        }

        else if (physicsBody.velocity.x > 0)
        {
            sprite.flipX = true;
        }
    }
}
