using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackRange = default;
    private Vector2 attackDirection = Vector2.right; // Початковий напрямок вправо

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;
    private float distanceFromPlayer = 1.0f;

    private void Start()
    {
        attackRange = transform.Find("AttackRange").gameObject;
        attackRange.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timeToAttack)
            {
                StopAttack();
            }
        }
        float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

 // Змінити напрямок атаки по горизонталі
    if (horizontalInput < 0)
    {
        attackDirection = Vector2.left;
    }
    else if (horizontalInput > 0)
    {
        attackDirection = Vector2.right;
    }

    // Змінити напрямок атаки по вертикалі
    if (verticalInput < 0)
    {
        attackDirection = Vector2.down;
    }
    else if (verticalInput > 0)
    {
        attackDirection = Vector2.up;
    }

    }

    private void Attack()
{
    attacking = true;
    attackRange.SetActive(true);

    if (Input.GetKey(KeyCode.A))
    {
        attackDirection = Vector2.left;
    }
    else if (Input.GetKey(KeyCode.D))
    {
        attackDirection = Vector2.right;
    }
    else if (Input.GetKey(KeyCode.W))
    {
        attackDirection = Vector2.up;
    }
    else if (Input.GetKey(KeyCode.S))
    {
        attackDirection = Vector2.down;
    }

    // Змінити напрямок атаки відповідно до напрямку персонажа
    Vector3 characterDirection = transform.localScale;
    if (characterDirection.x < 0)
    {
        attackDirection = new Vector2(-attackDirection.x, attackDirection.y);
    }

    // Змінити позицію attackRange відповідно до напрямку
    attackRange.transform.localPosition = attackDirection * distanceFromPlayer;

    // Запустити процес атаки
    StartCoroutine(PerformAttack());
}


    private IEnumerator PerformAttack()
    {
        // Чекати певний час для завершення атаки
        yield return new WaitForSeconds(timeToAttack);

        StopAttack();
    }

    private void StopAttack()
{
    attacking = false;
    attackRange.SetActive(false);
    timer = 0;

    // Змінити напрямок атаки на напрямок персонажа
    Vector3 characterDirection = transform.localScale;
    if (characterDirection.x < 0)
    {
        attackDirection = new Vector2(-attackDirection.x, attackDirection.y);
    }
}

}
