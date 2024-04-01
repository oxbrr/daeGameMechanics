using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public Collider2D boundaryCollider;
    public float damageAmount;

    private void Start()
    {
        damageAmount = 1000f;
        // Amount of damage to apply when a player touches the boundary
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to a GameObject with the "Player" layer
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Access the PlayerHealth script attached to the player GameObject
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();

            // If the player has a PlayerHealth script attached, apply damage to the player
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount); // Call a function to apply damage to the player
            }

            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                // Access the EnemyHealth script attached to the enemy GameObject
                EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();

                // If the enemy has a EnemyHealth script attached, apply damage to the enemy
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damageAmount); // Call a function to apply damage to the enemy
                }
            }
        }
    }
}