using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Nếu Player chạm vào
        {
            Debug.Log("Đã thu thập vật phẩm!");
            Destroy(gameObject); // Xóa vật phẩm khỏi màn chơi
        }
    }
}
