using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float FallSpeed { get; set; }

    /// <summary>
    /// ����� ������������ ���� � ���������� ���������
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.down * FallSpeed, Space.World);
    }

}
