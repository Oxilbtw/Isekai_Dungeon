using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public void TakeHit(int damage)//damage
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);//if hp = 0, player death
        }
    }

    public void SetHealth(int plusHealth) //plus hp = flaska
    {
        health += plusHealth;

        if (health > maxHealth) //tut robim tak, shob ne bulo 150 hp kolu hpmax = 100
        {
            health = maxHealth;
        }
    }
}
