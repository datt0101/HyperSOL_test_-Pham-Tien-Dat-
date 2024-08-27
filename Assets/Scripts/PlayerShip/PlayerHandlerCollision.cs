using UnityEngine;

public class PlayerHandlerCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            PlayerShipDamageReceiver.instance.ReceiveDamage(PlayerShipManager.instance.playerShipProfile.ShipHpMax);
        }
    }
}