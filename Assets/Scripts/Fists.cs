using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject leftFist;
    public GameObject rightFist;
    public float fistRotationSpeed = 10f;
    public float fistDamage = 5;

    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Player Attacked");
        }

    }
}
