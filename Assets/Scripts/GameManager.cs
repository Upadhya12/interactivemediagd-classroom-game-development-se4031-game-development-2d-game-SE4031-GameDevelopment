using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

<<<<<<< Updated upstream
    public int score = 0;
    public bool isGameOver = false;
=======
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject winText;

    private int score = 0;
    private bool isGameOver = false;
    private bool isWin = false;
>>>>>>> Stashed changes

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
<<<<<<< Updated upstream
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateScore(score);
        }
=======
        score = 0;
        UpdateScore();

        if (gameOverText != null)
            gameOverText.SetActive(false);
>>>>>>> Stashed changes

        if (winText != null)
            winText.SetActive(false);

        isGameOver = false;
        isWin = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
<<<<<<< Updated upstream
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
=======
        if ((!isGameOver && !isWin) || Keyboard.current == null) return;

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
>>>>>>> Stashed changes
        }
    }

    public void AddScore(int amount)
    {
<<<<<<< Updated upstream
        if (isGameOver) return;

        score += amount;

        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateScore(score);
        }
=======
        score += amount;
        UpdateScore();

        if (score >= 10)
        {
            WinGame();
        }
    }

    public void RemoveScore(int amount)
    {
        score -= amount;

        if (score < 0)
            score = 0;

        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
>>>>>>> Stashed changes
    }

    public void GameOver()
    {
        if (isGameOver || isWin) return;

        isGameOver = true;

<<<<<<< Updated upstream
        if (UIManager.Instance != null)
        {
            UIManager.Instance.ShowGameOver();
        }
=======
        if (gameOverText != null)
            gameOverText.SetActive(true);
>>>>>>> Stashed changes

        Time.timeScale = 0f;
    }

<<<<<<< Updated upstream
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
=======
    public void WinGame()
    {
        if (isGameOver || isWin) return;

        isWin = true;

        if (winText != null)
            winText.SetActive(true);

        Time.timeScale = 0f;
>>>>>>> Stashed changes
    }
}