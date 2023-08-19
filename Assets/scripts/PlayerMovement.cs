using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 1f;


    private void Update()
    {
        Vector2 inputVector = new Vector2 (0, 0);

        if (Input.GetKey(KeyCode.W)){
           inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S)){
           inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.D)){
           inputVector.x = +1;
        }
        if (Input.GetKey(KeyCode.A)){
           inputVector.x = -1;
        }
        inputVector = inputVector.normalized;
        
        Vector3 moveDir = new Vector3 (inputVector.x, inputVector.y, 0f);
        transform.position += moveDir * Time.deltaTime * speed;

        Debug.Log(inputVector);
    }
}
