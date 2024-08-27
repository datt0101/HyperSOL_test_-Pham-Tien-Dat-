using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class PlayerBullet : MonoBehaviour
{
    protected Rigidbody2D rb;
    public abstract void ShootBullet();
    public virtual void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        ShootBullet();
    }
    public virtual void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            target.gameObject.GetComponent<EnemyDamageReceiver>().ReceiveDamage(PlayerShipManager.instance.playerShipProfile.ShipDamage);
            Destroy(gameObject);
        }
        if (target.tag == "Boder")
        {
            Destroy(gameObject);
        }

    }

}
