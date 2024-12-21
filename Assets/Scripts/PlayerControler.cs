using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    private int speed = 20; // �������� ����������� ������
    private int force = 10; // ���� ��������

    public Rigidbody rb; // ������ �� ��������� Rigidbody

    void Update()
    {
        // �������� �������� ���� ����� ��� ��������������� � ������������� �����������
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // ���������� ������ ������ � ������� ��� � ����������� �� �����
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        // ���������, ������ �� ������� �������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��������� ������� � ������� �����
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
