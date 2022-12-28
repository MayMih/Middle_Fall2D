using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //[SerializeField] private float fallSpeed = 0.005f;

    public float FallSpeed { get; set; }

    //[SerializeField] private ObjectCreatorArea speedSource;

    /// <summary>
    /// Метод передвижения тела с ускорением свободного падения
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.down * FallSpeed, Space.World);
    }
}
