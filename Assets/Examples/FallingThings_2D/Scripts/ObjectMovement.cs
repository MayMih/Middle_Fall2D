using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //[SerializeField] private float fallSpeed = 0.005f;

    public float FallSpeed { get; set; }

    //[SerializeField] private ObjectCreatorArea speedSource;

    /// <summary>
    /// ����� ������������ ���� � ���������� ���������� �������
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.down * FallSpeed, Space.World);
    }
}
