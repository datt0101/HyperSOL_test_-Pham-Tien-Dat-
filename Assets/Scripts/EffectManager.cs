
using UnityEngine;
using DG.Tweening;
public class EffectManager : MonoBehaviour
{
    static public EffectManager instance;
    public GameObject victoyEf;
    public GameObject LoseEf;
    public GameObject LevelUpEf;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }
    public void TurnOn(GameObject ef)
    {
        //blackPanel.SetActive(true);
        ef.SetActive(true);
        ef.transform.localScale = Vector3.zero;
        ef.transform.DOScale(1f, 1f)
            .OnComplete(() =>
            {
                TurnOff(ef);
            });

    }
    public void TurnOff(GameObject ef)
    {
        ef.SetActive(false);

    }
    public void ActiveVictoryEf()
    {
        TurnOn(victoyEf);
    }
    public void ActiveLoseEf()
    {
        TurnOn(LoseEf);
    }
    public void ActiveLevelUpEf()
    {
        TurnOn(LevelUpEf);
    }
}
