using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target; // object player
    public float speed;
    public float maxrange;
    public float minrange;

    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    private void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <=maxrange && Vector3.Distance(target.position, transform.position) >= minrange)
        {
            FollowPlayer();
        }
    }
    public void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
