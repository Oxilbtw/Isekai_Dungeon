using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag) // if tag gameobjecta = player, to pri stolknoveniyi bude damage
        {
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage); // -hp
        }
    }
}
