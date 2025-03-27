using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    public float speed = 100f; // Tốc độ xoay

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime); // Xoay chướng ngại vật
    }
}
