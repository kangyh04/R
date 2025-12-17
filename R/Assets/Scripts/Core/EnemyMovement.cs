using UnityEngine;

[RequireComponent(typeof(EnemyController))]
public class EnemyMovement : MonoBehaviour
{
    private float speed = 1.0f;

    public void Move(Vector3 dir)
    {
        this.transform.position += dir * speed * Time.deltaTime;
    }
}
