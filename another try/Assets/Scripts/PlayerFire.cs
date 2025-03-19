using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // class wide variables
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    public void fireProjectile()
    {
        GameObject clonedProjectile;
        clonedProjectile = Instantiate(projectilePrefab);
        clonedProjectile.transform.position = transform.position;

        Rigidbody2D projectileBody;
        projectileBody = clonedProjectile.GetComponent<Rigidbody2D>();

        projectileBody.velocity = projectileVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (sprite.flipX == true)
        {
            projectileVelocity.x = 10;
        }
        else
        {
            projectileVelocity.x = -10;
        }
    }
}
