using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    private int speed = 20; // Скорость перемещения игрока
    private int force = 10; // Сила импульса

    public Rigidbody rb; // Ссылка на компонент Rigidbody

    void Update()
    {
        // Получаем значения осей ввода для горизонтального и вертикального перемещения
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Перемещаем объект вперед и вращаем его в зависимости от ввода
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        // Проверяем, нажата ли клавиша пробела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Применяем импульс к объекту вверх
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
