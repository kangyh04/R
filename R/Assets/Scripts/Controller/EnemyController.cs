using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private EnemyMovement enemyMovement;
    private PlayerController playerController;

    private void Awake()
    {
        playerController = PlayerController.Instance;
    }

    void Update()
    {
        var dir = (playerController.transform.position - this.transform.position).normalized;
        enemyMovement.Move(dir);
    }
}
