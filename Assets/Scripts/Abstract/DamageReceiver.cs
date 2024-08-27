using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class DamageReceiver : MonoBehaviour
{
    public GameObject receiveDamageEffect;
    public GameObject dieEffect;
    public abstract float ObjectHp();
    public abstract float ObjectHpMax();
    public abstract Transform ObjectTransform();

    public abstract void DeductHp(float value);

    virtual public void ReceiveDamage(float value)
    {
        DeductHp(value);
        StartCoroutine(ActiveReceiveDamageEffect(receiveDamageEffect, 0.2f));
        CheckDie(ObjectHp());
    }

    virtual public void CheckDie(float objectHp)
    {
        if(objectHp<=0)
        {
            StartCoroutine(ActiveReceiveDamageEffect(dieEffect, 1.5f));
        }
    }

    public IEnumerator ActiveReceiveDamageEffect(GameObject effect, float timeActive)
    {
        effect.SetActive(true);
        yield return new WaitForSeconds(timeActive);
        effect.SetActive(false);

    }

 
}