using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -1;
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = 1;
        physicsBody.velocity = newVelocity;
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
