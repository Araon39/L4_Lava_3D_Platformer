using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        // ��� ��� �������� ������ ����� � ������ �� ���� �� �� ������������ (������������ �� 2 ������) ���������� UnityEngine.SceneManagement
        //UnityEngine.SceneManagement.SceneManager.LoadScene(0); 

        // ��� ��� �������� ����� �� ����� ��� ������� ���������� UnityEngine.SceneManagement
        SceneManager.LoadScene("Game");
    }
}
