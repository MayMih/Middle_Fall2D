using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// Метод передвижения тела с ускорением свободного падения
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed, Space.World);
    }
}
