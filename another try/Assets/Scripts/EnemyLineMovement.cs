using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    // public variables
    // exposed for editing in unity editor

    public float forceStrength; //how fast the enemy is

    public Vector2 direction; // what direction the enemy is moving in
    
    // private variables
    // not exposed, cannot be edited in the engine

    private Rigidbody2D rigidbody; //the container for the rigidbody attached to the gameObject


    //when the script is first loaded
    void Awake()
    {
        // get and store rigidbody
        rigidbody = GetComponent<Rigidbody2D>();

        //normalise the direction
        direction = direction.normalized;
    }


    // Update is called once per frame
    void Update()
    {
        //move in correct direction with set force strength
        rigidbody.AddForce(direction * forceStrength);
    }
}
