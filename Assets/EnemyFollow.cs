using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Giữ nguyên Transform thay vì lấy Vector3
    public float speed = 2f;

    void Update()
    {
        if (player != null) // Nếu Player không null, cập nhật vị trí
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
