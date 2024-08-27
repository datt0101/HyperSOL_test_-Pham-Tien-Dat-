using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class WaveEnemyMovement : MoveToTargetMovement
{
    [SerializeField] private float speed;
    private void Update()
    {
        Move(speed);
    }

}