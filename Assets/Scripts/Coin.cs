using UnityEngine;

// ������ Unity (1 ������ �� �������) | ������: 0
public class Coin : MonoBehaviour
{
    // �������� �������� ������
    private int rotationSpeed = 70;

    // ��������� Unity | ������: 0
    void Update()
    {
        // ������� ������ ������ ��� Y �� ����, ��������� �� ������� � �������� ��������
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
    }
}
