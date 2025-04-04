using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu; // Kéo MainMenuPanel vào đây trong Inspector

    void Start()
    {
        mainMenu.SetActive(true); // Hiện Menu khi game bắt đầu
    }

    public void StartGame()
    {
        mainMenu.SetActive(false); // Ẩn menu
        SceneManager.LoadScene("GameScene"); // Chuyển sang màn chơi (Đảm bảo có Scene tên GameScene)
    }

    public void QuitGame()
    {
        Debug.Log("Thoát Game!");
        Application.Quit(); // Thoát game (Chỉ hoạt động khi build)
    }
}
