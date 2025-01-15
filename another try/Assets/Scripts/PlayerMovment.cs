using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

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
        
    }
}
