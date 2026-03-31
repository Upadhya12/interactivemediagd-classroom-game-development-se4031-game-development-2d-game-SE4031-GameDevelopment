using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
<<<<<<< Updated upstream
=======
    public int wallDamage = 10;
    public int enemyDamage = 20;

    private bool healUsed = false;
>>>>>>> Stashed changes

    void Start()
    {
        currentHealth = maxHealth;
<<<<<<< Updated upstream
        UIManager.Instance.UpdateHealth(currentHealth, maxHealth);
=======
        UpdateUI();
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.hKey.wasPressedThisFrame)
            TakeDamage(10);

        if (Keyboard.current.jKey.wasPressedThisFrame && !healUsed)
        {
            Heal(20);
            healUsed = true;

            if (UIManager.Instance != null)
                UIManager.Instance.HideHealHint();
        }
>>>>>>> Stashed changes
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
<<<<<<< Updated upstream

        if (currentHealth < 0)
            currentHealth = 0;

        UIManager.Instance.UpdateHealth(currentHealth, maxHealth);

        if (currentHealth == 0)
        {
            GameManager.Instance.GameOver();
        }
=======
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateUI();

        if (currentHealth == 0 && GameManager.Instance != null)
            GameManager.Instance.GameOver();
>>>>>>> Stashed changes
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
<<<<<<< Updated upstream

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        UIManager.Instance.UpdateHealth(currentHealth, maxHealth);
=======
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateUI();
>>>>>>> Stashed changes
    }

    public void ResetHealth()
    {
<<<<<<< Updated upstream
        currentHealth = maxHealth;
        UIManager.Instance.UpdateHealth(currentHealth, maxHealth);
=======
        if (UIManager.Instance != null)
            UIManager.Instance.UpdateHealth(currentHealth, maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
            TakeDamage(wallDamage);

        if (collision.gameObject.CompareTag("Enemy"))
            TakeDamage(enemyDamage);
>>>>>>> Stashed changes
    }
}