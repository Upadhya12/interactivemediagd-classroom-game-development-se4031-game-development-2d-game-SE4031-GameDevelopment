using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;
    public int scoreValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy touched by: " + collision.tag);

        if (collision.CompareTag("Projectile"))
        {
            Debug.Log("Projectile hit enemy");

            if (GameManager.Instance != null)
            {
                Debug.Log("GameManager exists, adding score");
                GameManager.Instance.AddScore(scoreValue);
            }
            else
            {
                Debug.Log("GameManager.Instance is NULL");
            }

            Destroy(gameObject);
            return;
        }

        if (collision.CompareTag("Player"))
        {
            PlayerHealth player = collision.GetComponent<PlayerHealth>();

            if (player != null)
            {
                player.TakeDamage(damage);
            }

            if (GameManager.Instance != null)
            {
                GameManager.Instance.RemoveScore(1);
            }

            Destroy(gameObject);
            return;
        }

        if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}