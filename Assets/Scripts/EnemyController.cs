using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // ��������� ��������� ���������� ��� �������� ������ �� ������, �����������, �������� � ������� �����
    private Transform player;       // ������ �� ������
    private Vector3 direction;     // ����������� �������� �����
    private float speed = 3f;       // �������� �������� �����
    private float attackRange = 3f; // ������ ����� �����
    private float distanceToPlayer; // ���������� �� ������

    // ����� Start ���������� ����� ������ ������ ����������
    void Start()
    {
        // ������� ������ �� ���� "Player" � ��������� ��� ���������
        player = GameObject.Find("Player").transform;
    }

    // ����� Update ���������� ���� ��� �� ����
    void Update()
    {
        // ��������� ���������� ����� ������ � �������
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ���� ���������� �� ������ ������ ������� �����
        if (distanceToPlayer <= attackRange)
        {
            // ��������� ����������� �� ����� � ������
            direction = (player.position - transform.position ).normalized;

            // ���������� ����� � ����������� ������ �� ��������� speed
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
