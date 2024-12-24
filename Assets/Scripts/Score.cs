using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int count;                  // Переменная для хранения количества монет
    public TextMeshProUGUI scoreText;   // Объект TextMeshProUGUI для отображения текста счета

    void Start()
    {        
        count = 0;                                          // Инициализация счетчика монет
        scoreText.text = "Coins: " + count.ToString();      // Установка начального текста счета
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Проверка, столкнулись ли мы с объектом с тегом "Coin"
        if (collision.gameObject.CompareTag("Coin"))
        {            
            count++;                                        // Увеличение счетчика монет           
            scoreText.text = "Coins: " + count.ToString();  // Обновление текста счета            
            Destroy(collision.gameObject);                  // Уничтожение объекта монеты
        }
    }
}
