using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;
<<<<<<< Updated upstream
=======
    public Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
>>>>>>> Stashed changes

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag) // if tag gameobjecta = player, to pri stolknoveniyi bude damage
        {
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage); // -hp
<<<<<<< Updated upstream
=======

            Vector2 damageDirection = playerTransform.position - transform.position;
            coll.gameObject.GetComponent<PlayerMovement>().TakeDamage(damageDirection.normalized);
>>>>>>> Stashed changes
        }
    }
}
