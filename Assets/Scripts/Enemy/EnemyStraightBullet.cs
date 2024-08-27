using UnityEngine;
using UnityEngine.UIElements;

public class EnemyStraightBullet : EnemyBullet
{
    public override void ShootBullet()
    {
        //Debug.Log("Shot");
        rb.velocity = transform.up * enemyModel.enemyInstanceProfile.EnemyBulletSpeed;
    }
}
