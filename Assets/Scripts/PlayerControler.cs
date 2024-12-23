using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    private int speed = 20;
    private int rotationSpeed = 60;
    public int force = 7;

    public bool onIsland;

    public Rigidbody rb;

    void Update()
    {
        // Получаем значения осей ввода
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Перемещаем объект вперед и вращаем его
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

        // Проверяем, нажата ли клавиша пробел и находимся ли на острове
        if (Input.GetKeyDown(KeyCode.Space) && onIsland == true)
        {
            // Применяем силу к объекту, чтобы он подпрыгнул
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onIsland = false;
        }
    }

    // Метод вызывается при столкновении с другим объектом
    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, столкнулись ли мы с объектом с тегом "Island"
        if (collision.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    }
}
