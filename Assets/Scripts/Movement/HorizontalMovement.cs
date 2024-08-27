using UnityEngine;

public class HorizontalMovement : Movement
{
    public override void Move(float speed)
    { 
        float horizontal = Mathf.Sin(Time.time * speed) * 2.0f;
        transform.Translate(new Vector3(horizontal, 0, 0) * Time.deltaTime);
    }
}
