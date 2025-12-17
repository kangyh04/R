using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
public class PlayerMovement : MonoBehaviour
{
    private float speed = 1.0f;

    void OnMove(InputValue value)
    {
        var dir = value.Get<Vector2>();
        Debug.LogError(dir);
        this.transform.position += new Vector3(dir.x, dir.y, 0.0f) * speed * Time.deltaTime;
    }
}
