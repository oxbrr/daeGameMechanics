using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 10f; // Maximum health of the enemy
    private float currentHealth; // Current health of the enemy
    public GameObject Enemy;

    void Start() 
    {
        currentHealth = maxHealth; // Initialize current health to max health at the start
    }

    // Function to apply damage to the enemy
    public void TakeDamage(float damageAmount)
    {
        // Subtract the damage amount from the current health
        currentHealth -= damageAmount;

        // Check if the enemies' health is zero or below
        if (currentHealth <= 0)
        {
            Die(); // Call the Die function if the player's health is zero or below
        }
    }

    // Function to handle enemy death
    void Die()
    {
        // Perform actions to handle enemy death, such as playing death animations, sounds, etc.
        Debug.Log("Enemy has died!");

        Destroy(Enemy);
    }
}
