using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
<<<<<<< Updated upstream
    private Transform target; // object player
    public float speed;
    public float maxrange;
    public float minrange;
=======

    private Transform target; // object player
    [SerializeField] private float speed;
    [SerializeField] private float maxrange;
    [SerializeField] private float minrange;
>>>>>>> Stashed changes

    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    private void Update()
    {
<<<<<<< Updated upstream
        
        if (Vector3.Distance(target.position, transform.position) <=maxrange && Vector3.Distance(target.position, transform.position) >= minrange)
=======
        if (Vector3.Distance(target.position, transform.position) <= maxrange && Vector3.Distance(target.position, transform.position) >= minrange) 
>>>>>>> Stashed changes
        {
            FollowPlayer();
        }
    }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    public void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
}
