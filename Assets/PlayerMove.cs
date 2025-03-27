using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector2(moveX, moveY) * speed * Time.deltaTime);
    }
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Va chạm với: " + other.gameObject.name); // Debug xem có nhận va chạm không

        if (other.CompareTag("Obstacle") || other.CompareTag("Enemy")) // Kiểm tra cả Enemy
        {
            Debug.Log("Chạm vào chướng ngại vật hoặc Enemy! Reset về vị trí ban đầu.");
            transform.position = startPos;
        }
        else if (other.CompareTag("Goal"))
        {
            Debug.Log("You Win!");
        }
    }
}