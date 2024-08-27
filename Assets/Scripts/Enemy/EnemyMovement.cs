using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private EnemyModel enemyModel;
    [SerializeField] private Movement movement;

    private void Update()
    {
        movement.Move(enemyModel.enemyInstanceProfile.EnemySpeed);
    }
}