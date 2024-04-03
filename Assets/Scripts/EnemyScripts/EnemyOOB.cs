using UnityEngine;

public class EnemyBoundaryController : MonoBehaviour
{
    public Collider2D boundaryCollider;
    public float damageAmount;

    private void FixedUpdate()
    {
        damageAmount = 1000f;
        // Amount of damage to apply when a player touches the boundary
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to a GameObject with the "Player" layer
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            // Access the EnemyHealth script attached to the enemy GameObject
            EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();

            // If the player has a PlayerHealth script attached, apply damage to the player
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageAmount); // Call a function to apply damage to the player
            }
        }
    }
}