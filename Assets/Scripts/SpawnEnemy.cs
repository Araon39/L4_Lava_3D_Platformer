using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Объявляем публичные переменные для хранения ссылки на врага и массива островов
    public GameObject enemy;       // Префаб врага
    public GameObject[] islands;  // Массив островов

    // Метод Start вызывается перед первым кадром обновления
    void Start()
    {
        // Находим все объекты с тегом "Island" и сохраняем их в массиве islands
        islands = GameObject.FindGameObjectsWithTag("Island");

        // Проходим по всем островам
        for (int i = 0; i < islands.Length; i++)
        {
            // Генерируем случайную позицию на острове
            Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));

            // Создаем врага на этой позиции с нулевым вращением (Quaternion.identity)
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
