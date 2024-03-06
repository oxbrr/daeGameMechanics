using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public Collider2D boundaryCollider;
    public float damageAmount = 10f; // Amount of damage to apply when a player touches the boundary

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to a GameObject with the "Player" layer
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Access the PlayerHealth script attached to the player GameObject (assuming it has one)
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();

            // If the player has a PlayerHealth script attached, apply damage to the player
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10); // Call a function to apply damage to the player
            }
        }
    }
}
    