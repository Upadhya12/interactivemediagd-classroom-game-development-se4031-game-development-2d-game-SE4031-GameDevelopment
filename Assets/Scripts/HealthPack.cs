using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 20;
    public float moveSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -10f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth player = collision.GetComponent<PlayerHealth>();

            if (player != null)
                player.Heal(healAmount);

            Destroy(gameObject);
        }
    }
}