using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public Collider2D boundaryCollider;

    void Update()
    {
        // Get all colliders within the boundary
        Collider2D[] colliders = Physics2D.OverlapBoxAll(boundaryCollider.bounds.center, boundaryCollider.bounds.size, 0f);

        // Iterate through all colliders and check if they are on the "Player" layer
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                // If the collider is on the "Player" layer, remove or disable the GameObject
                collider.gameObject.SetActive(false);
            }
        }
    }
}
