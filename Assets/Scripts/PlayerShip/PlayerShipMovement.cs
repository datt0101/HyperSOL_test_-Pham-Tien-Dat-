
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : Movement
{
    private float padding;
    private float xmax, xmin, ymin, ymax;   
    private float distance;
    void Start()
    {
        padding = 0.5f;
        Camera camera = Camera.main;  
        distance = camera.transform.position.z - transform.position.z;
        xmin = camera.ViewportToWorldPoint(new Vector3(0,0, distance)).x + padding;
        xmax = camera.ViewportToWorldPoint(new Vector3(1,0,distance)).x - padding;
        ymin = camera.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + padding;
        ymax = camera.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - padding;
    }
    void Update()
    {
       
        Move(PlayerShipManager.instance.playerShipProfile.ShipSpeed);
        ClampPosition();
    }
    public override void Move(float speed)
    {
        float h = InputManager.instance.horizontalInput;
        float v = InputManager.instance.verticalInput;
        transform.Translate(new Vector3(h, v, 0) * speed * Time.deltaTime);
    }
    void ClampPosition()
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, xmin, xmax);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, ymin, ymax);
        transform.position = clampedPosition;
    }

}
