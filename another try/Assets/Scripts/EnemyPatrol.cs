using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    //public variables
    public float forceStrength; // speed of the AI
    public Vector2[] patrolPoints; // points that the AI moves to
    public float stopDistance; // how close we get before moving to the next point

    // private variables
    private Rigidbody2D AIRigidBody;
    private int currentPoint = 0; // index of current point we are moving to

    //Awake is called when script is loaded
    private void Awake()
    {
        AIRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        // if we are closer to our target than min distance...
        if (distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;

            }
        }

        //to get the direction we need to move in,
        //we subtract the current position from the target position

        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;
        AIRigidBody.AddForce(direction * forceStrength);
    }
}
