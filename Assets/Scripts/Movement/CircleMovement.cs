using UnityEngine;

public class CircleMovement : Movement
{
    [SerializeField] private Transform centerPoint;
    [SerializeField] private float radius;
    private float angle;
    void Start()
    {
        radius = Vector3.Distance(transform.position, centerPoint.position);
        Vector3 offset = transform.position - centerPoint.position;
        angle = Mathf.Atan2(offset.y, offset.x);
    }
    public override void Move(float speed)
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, y, 0) + centerPoint.position;
    }
    
}
