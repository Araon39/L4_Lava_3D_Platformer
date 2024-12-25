using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // ��������� ��������� ���������� ��� �������� ������ �� ����� � ������� ��������
    public GameObject enemy;       // ������ �����
    public GameObject[] islands;  // ������ ��������

    // ����� Start ���������� ����� ������ ������ ����������
    void Start()
    {
        // ������� ��� ������� � ����� "Island" � ��������� �� � ������� islands
        islands = GameObject.FindGameObjectsWithTag("Island");

        // �������� �� ���� ��������
        for (int i = 0; i < islands.Length; i++)
        {
            // ���������� ��������� ������� �� �������
            Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));

            // ������� ����� �� ���� ������� � ������� ��������� (Quaternion.identity)
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
