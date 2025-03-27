using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float minY = -2f;
    public float maxY = 2f;
    public float speed = 2f;
    int dir = 1;

    void Update()
    {
        transform.Translate(Vector2.up * dir * speed * Time.deltaTime);
        if (transform.position.y > maxY || transform.position.y < minY)
            dir *= -1;
    }
}
