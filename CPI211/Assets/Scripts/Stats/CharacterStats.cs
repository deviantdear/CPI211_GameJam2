using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    // Health
    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public int damage = 100;

    // Set current health to max health
    // when starting the game.
    void Awake()
    {
        currentHealth = maxHealth;
    }

    // Damage the character
    public void TakeDamage(int damage)
    {
        //Prevents damage from ever being more or less than the max value and zero
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        // Damage the character
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        // If health reaches zero
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        // Die in some way
        // This method is meant to be overwritten
        Debug.Log(transform.name + " died.");

        //Player needs to be re-transported to last scene if re-trying the level.
    }
}
