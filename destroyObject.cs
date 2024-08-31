using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    void Start()
    {
        // Уничтожаем этот объект при старте игры
        Destroy(gameObject);
    }
}
