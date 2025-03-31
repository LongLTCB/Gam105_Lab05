using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public float bestTime = Mathf.Infinity; // Lưu thời gian tốt nhất (mặc định vô cực)
}
