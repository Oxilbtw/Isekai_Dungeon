using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{

   [SerializeField] private float knockbackForce = 1f;
   [SerializeField] private float decelerationRate = 1f;
   [SerializeField] private float speed = 1f;
   private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(Vector2 damageDirection)
    {
        // Применяем отталкивание к текущей скорости
        rb.velocity -= damageDirection * knockbackForce;
    }

    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        inputVector = inputVector.normalized;

        // Не изменяем позицию напрямую

        // Применяем скорость на основе ввода
        Vector2 moveVelocity = new Vector2(inputVector.x * speed, inputVector.y * speed);
        rb.velocity = moveVelocity;

        // Применяем замедление
        rb.velocity *= (1f - decelerationRate * Time.deltaTime);

        //Debug.Log(inputVector);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("OnTrigger");
        if (other.CompareTag("Enemy")) // Проверяем тег врага
        {
            Debug.Log("Enemy");
            Vector2 damageDirection = (transform.position - other.transform.position).normalized;
            TakeDamage(damageDirection);
        }
    }
}
