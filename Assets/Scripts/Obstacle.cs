using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D rb;

    public float minSize = 0.5f;
    public float maxSize = 1.5f;

    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1f);

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        rb.AddForce(randomDirection * randomSpeed);
    }
}
