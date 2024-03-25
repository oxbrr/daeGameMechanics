using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Maximum health of the player
    private float currentHealth; // Current health of the player

    void Start()
    {
        currentHealth = maxHealth; // Initialize current health to max health at the start
    }

    // Function to apply damage to the player
    public void TakeDamage(float damageAmount)
    {
        // Subtract the damage amount from the current health
        currentHealth -= damageAmount;

        // Check if the player's health is zero or below
        if (currentHealth <= 0)
        {
            Die(); // Call the Die function if the player's health is zero or below
        }
    }

    // Function to handle player death
    void Die()
    {
        // Perform actions to handle player death, such as playing death animations, sounds, etc.
        Debug.Log("Player has died!");

        // Load the main menu scene
        SceneManager.LoadScene("DeathMenu");
    }
}
