using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Sprite cursorSprite; // Sprite for the custom cursor
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Create a new GameObject for the custom cursor
        GameObject cursorObject = new GameObject("CustomCursor");
        spriteRenderer = cursorObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = cursorSprite;
    }

    private void Update()
    {
        // Get the mouse position in world coordinates
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Update the position of the custom cursor
        transform.position = cursorPosition;
    }
}
