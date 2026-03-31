using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Slider healthBar;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
<<<<<<< Updated upstream
=======
    public TextMeshProUGUI healHintText;
    public Image fillImage;
>>>>>>> Stashed changes

    void Awake()
    {
        Instance = this;
    }

<<<<<<< Updated upstream
=======
    void Start()
    {
        if (scoreText != null)
            scoreText.text = "Score: 0";

        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false);

        if (healHintText != null)
            healHintText.gameObject.SetActive(true);
    }

>>>>>>> Stashed changes
    public void UpdateHealth(int current, int max)
    {
        if (healthBar != null)
        {
            healthBar.maxValue = max;
            healthBar.value = current;
        }
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void ShowGameOver()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }

    public void HideHealHint()
    {
        if (healHintText != null)
            healHintText.gameObject.SetActive(false);
    }
}