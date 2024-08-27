using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyBullet : MonoBehaviour
{
    public EnemyModel enemyModel;
    protected Rigidbody2D rb;
    public abstract void ShootBullet();
    public virtual void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        ShootBullet();
     
    }

    public virtual void OnTriggerEnter2D(Collider2D target)
    {
        Debug.Log(target.tag);
        if (target.tag == "Player")
        {
            //Debug.Log(enemy.enemyInstanceProfile.EnemyName);
            PlayerShipManager.instance.playerShipDamageReceiver.ReceiveDamage(enemyModel.enemyInstanceProfile.EnemyDamage);
            Destroy(gameObject);
        }

        if (target.tag == "Boder")
        {
            Destroy(gameObject);
        }
    }

}
