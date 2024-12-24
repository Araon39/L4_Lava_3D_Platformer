using UnityEngine;

// Скрипт Unity (1 ссылка на ресурсы) | Ссылок: 0
public class Coin : MonoBehaviour
{
    // Скорость вращения монеты
    private int rotationSpeed = 70;

    // Сообщение Unity | Ссылок: 0
    void Update()
    {
        // Вращаем объект вокруг оси Y на угол, зависящий от времени и скорости вращения
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
    }
}
