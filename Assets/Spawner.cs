using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player; // Đảm bảo kéo Player vào Inspector

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 3f); // Mỗi 3 giây spawn 1 Enemy
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        // Lấy script của Enemy và gán Player cho nó
        EnemyFollow enemyScript = enemy.GetComponent<EnemyFollow>();
        if (enemyScript != null)
        {
            enemyScript.player = player; // Gán cả Transform của Player, không chỉ vị trí ban đầu
        }
        else
        {
            Debug.LogError("Không tìm thấy script EnemyFollow trên Enemy!");
        }
    }
}
