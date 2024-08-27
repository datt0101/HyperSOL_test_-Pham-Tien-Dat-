
public class PlayerStraightBullet : PlayerBullet
{
    public override void ShootBullet()
    {
        rb.velocity = transform.up * PlayerShipManager.instance.playerShipProfile.ShipBulletSpeed;
    }
}
