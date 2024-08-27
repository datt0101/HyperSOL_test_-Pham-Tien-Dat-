using System.Collections;
using Unity;
using UnityEngine;

public class PlayerShipDamageReceiver : DamageReceiver
{
    static public PlayerShipDamageReceiver instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);

    }
    public override float ObjectHp()
    {
        return PlayerShipManager.instance.playerShipProfile.ShipHp;
    }

    public override float ObjectHpMax()
    {
        return PlayerShipManager.instance.playerShipProfile.ShipHpMax;
    }

    public override Transform ObjectTransform()
    {
        return PlayerShipManager.instance.playerShipMovement.transform;
    }
    public override void DeductHp(float value)
    {
        float hpLost = value;
        if (hpLost < 0)
        {
            hpLost = 0;
        }

        PlayerShipManager.instance.playerShipProfile.ShipHp -= hpLost;
    }
    public override void ReceiveDamage(float value)
    {
        base.ReceiveDamage(value);
        PlayerUI.instance.UpdateHpBar();
    }

    public override void CheckDie(float objectHp)
    {
        if (objectHp <= 0)
        {
            PlayerShipManager.instance.playerShipProfile.ShipHp = PlayerShipManager.instance.playerShipProfile.ShipHpMax;
            PlayerShipManager.instance.playerShipCollider2D.enabled = false;
            PlayerShipManager.instance.playerShipSpriteRenderer.enabled = false;
            PlayerShipManager.instance.playerSpawnBullet.enabled = false;
            PlayerShipManager.instance.playerShipMovement.enabled = false;
            EffectManager.instance.ActiveLoseEf();
            StartCoroutine(ActiveReceiveDamageEffect(dieEffect, 2.5f));
            Invoke("EndGame", 3f);
        }
    }

    public void EndGame()
    {
        SceneManager.instance.LoadLevel(2);
    }    
   


}