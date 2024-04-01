using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject leftFist;
    public GameObject rightFist;
    public float fistRotationSpeed = 10f;
    public float fistDamage = 20;
    public LayerMask enemyLayer;
    public Collider2D LeftHitbox;
    public Collider2D RightHitbox;
    public KeyCode attackKey = KeyCode.Mouse0;

    private void Update()
    {
        // Check for mouse click
        if (Input.GetKeyDown(attackKey))
        {
            Attack(leftFist, LeftHitbox);
            Attack(rightFist, RightHitbox);
        }
        // this part is for the fists tracking the cursor
        // Get the mouse position in the world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Ensure the mouse position is at the same z-coordinate as the player

        // Calculate the direction vector from the player to the mouse
        Vector3 direction = mousePosition - transform.position;

        // Calculate the angle between the direction vector and the right direction (1,0,0)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the fists to point towards the mouse
        leftFist.transform.rotation = Quaternion.Slerp(leftFist.transform.rotation, Quaternion.Euler(0f, 0f, angle), Time.deltaTime * fistRotationSpeed);
        rightFist.transform.rotation = Quaternion.Slerp(rightFist.transform.rotation, Quaternion.Euler(0f, 0f, angle), Time.deltaTime * fistRotationSpeed);
    }

    private void Attack(GameObject fist, Collider2D hitbox)
    {
        // Activate the hitbox collider
        hitbox.enabled = true;

        // Schedule deactivation after a short delay
        Invoke("DeactivateHitbox", 0.1f);

        // Check for collisions during the attack
        Collider2D[] colliders = Physics2D.OverlapBoxAll(hitbox.bounds.center, hitbox.bounds.size, 0f, enemyLayer);
        foreach (Collider2D collider in colliders)
        {
            // Get Enemy Health script so you can actually kill them
            EnemyHealth enemyHealth = collider.GetComponent<EnemyHealth>();

            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(fistDamage);
            }
        }
    }

    private void DeactivateHitbox()
    {
        // Deactivate both hitboxes after the attack
        LeftHitbox.enabled = false;
        RightHitbox.enabled = false;
    }
}