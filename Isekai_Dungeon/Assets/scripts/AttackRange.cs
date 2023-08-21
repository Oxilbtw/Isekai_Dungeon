using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    private int damagerange = 10;

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.TakeHit(damagerange);
        }
    }
}
