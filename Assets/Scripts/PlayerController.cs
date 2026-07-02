using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera mainCamera;

    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 mousePosition2 = new Vector2(mousePosition.x, mousePosition.y);
        rb.position = Vector2.MoveTowards(rb.position, mousePosition2, speed * Time.fixedDeltaTime);
    }
}
