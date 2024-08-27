using System.Collections;
using Unity;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{

    [SerializeField] private EnemyModel enemyModel;

    private void Start()
    {
        receiveDamageEffect = gameObject.transform.GetChild(1).gameObject;
        dieEffect = gameObject.transform.GetChild(2).gameObject;
        enemyModel = GetComponent<EnemyModel>();
    }
    public override float ObjectHp()
    {
        return enemyModel.enemyInstanceProfile.EnemyHP;
    }

    public override float ObjectHpMax()
    {
        return enemyModel.enemyInstanceProfile.EnemyHpMax;
    }

    public override Transform ObjectTransform()
    {
        return enemyModel.transform;
    }
    public override void DeductHp(float value)
    {
        float hpLost = value - enemyModel.enemyInstanceProfile.EnemyArmor;
        if (hpLost < 0)
        {
            hpLost = 0;
        }

        enemyModel.enemyInstanceProfile.EnemyHP -= hpLost;
    }
    public override void ReceiveDamage(float value)
    {
        base.ReceiveDamage(value);
    }

    public override void CheckDie(float objectHp)
    {
        if (objectHp <= 0)
        {
            enemyModel.enemyInstanceProfile.EnemyHP = enemyModel.enemyInstanceProfile.EnemyHpMax;

            StartCoroutine(DieSequence());
        }
    }

    private IEnumerator DieSequence()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        yield return StartCoroutine(ActiveReceiveDamageEffect(dieEffect, 0.5f));
        enemyModel.gameObject.SetActive(false);
        ScoreManager.instance.Score += enemyModel.enemyInstanceProfile.EnemyScore;
        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
        EnemyGameManager.instance.SwitchLevel();
        //enemyModel.transform.position = EnemyManager.instance.transform.position;
    }


}