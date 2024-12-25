using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Объявляем приватные переменные для хранения ссылки на игрока, направления, скорости и радиуса атаки
    private Transform player;       // Ссылка на игрока
    private Vector3 direction;     // Направление движения врага
    private float speed = 3f;       // Скорость движения врага
    private float attackRange = 3f; // Радиус атаки врага
    private float distanceToPlayer; // Расстояние до игрока

    // Метод Start вызывается перед первым кадром обновления
    void Start()
    {
        // Находим игрока по тегу "Player" и сохраняем его трансформ
        player = GameObject.Find("Player").transform;
    }

    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Вычисляем расстояние между врагом и игроком
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Если расстояние до игрока меньше радиуса атаки
        if (distanceToPlayer <= attackRange)
        {
            // Вычисляем направление от врага к игроку
            direction = (player.position - transform.position ).normalized;

            // Перемещаем врага в направлении игрока со скоростью speed
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
