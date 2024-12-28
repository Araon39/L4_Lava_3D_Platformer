using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        // Это для загрузки первой сцены в списке но если мы не использовали (неподключили во 2 строке) библиотеку UnityEngine.SceneManagement
        //UnityEngine.SceneManagement.SceneManager.LoadScene(0); 

        // Это для загрузки сцены по имени при наличии библиотеки UnityEngine.SceneManagement
        SceneManager.LoadScene("Game");
    }
}
