using TMPro;
using UnityEngine;

public class MoveToTargetMovement : Movement
{
    [SerializeField] private Transform targetPosition;

    public override void Move(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
    }
}