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
        // �������� �������� ���� �����
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // ���������� ������ ������ � ������� ���
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

        // ���������, ������ �� ������� ������ � ��������� �� �� �������
        if (Input.GetKeyDown(KeyCode.Space) && onIsland == true)
        {
            // ��������� ���� � �������, ����� �� ����������
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onIsland = false;
        }
    }

    // ����� ���������� ��� ������������ � ������ ��������
    private void OnCollisionEnter(Collision collision)
    {
        // ���������, ����������� �� �� � �������� � ����� "Island"
        if (collision.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    }
}
