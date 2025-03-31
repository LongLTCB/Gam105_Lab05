using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen; // Giao diện Win Game

    void Start()
    {
        winScreen.SetActive(false); // Ẩn màn hình Win ban đầu
    }

    public void WinGame()
    {
        winScreen.SetActive(true); // Hiện màn hình Win
        Time.timeScale = 0f; // Dừng game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Reset thời gian
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart game
    }
}
