using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //kill enemy function
    public void KillEnemy(GameObject enemy)
    {
        Destroy(gameObject);
        Destroy(enemy);
    }

    public void KillBullet(GameObject bullet)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy") == true)
        {
            KillEnemy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
