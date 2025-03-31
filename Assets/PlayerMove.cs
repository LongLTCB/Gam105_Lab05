using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f; // Tốc độ di chuyển
    private Rigidbody2D rb;
    private Vector3 respawnPosition; // Vị trí hồi sinh
    private GameManager gameManager; // Tham chiếu đến GameManager

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPosition = transform.position; // Lưu vị trí ban đầu làm điểm hồi sinh
        gameManager = FindObjectOfType<GameManager>(); // Tìm GameManager
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Di chuyển ngang (A/D hoặc mũi tên)
        float moveY = Input.GetAxisRaw("Vertical"); // Di chuyển dọc (W/S hoặc mũi tên)

        rb.velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle")) // Nếu va vào chướng ngại vật
        {
            Debug.Log("Chạm vật cản! Reset về vị trí ban đầu.");
            transform.position = respawnPosition; // Reset vị trí
        }
        else if (other.CompareTag("Goal")) // Nếu chạm vào đích
        {
            Debug.Log("You Win!");
            gameManager.WinGame(); // Gọi hàm hiện màn hình Win
        }
    }
}
