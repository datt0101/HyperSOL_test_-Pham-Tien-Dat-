using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGameManager : MonoBehaviour
{
    public static EnemyGameManager instance;
    [SerializeField] private List<EnemyLevelManager> levelList;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SwitchLevel()
    {
        for (int i = 0; i < levelList.Count; ++i)
        {
            if (levelList[i].gameObject.activeInHierarchy)
            {
                if (!levelList[i].IsEndLevel())
                    break;

                if (levelList[i].IsEndLevel() && i == levelList.Count - 1)
                {
                    levelList[i].gameObject.SetActive(false);
                    EffectManager.instance.ActiveVictoryEf();
                    Invoke("EndGame", 3f);
                    break;
                }

                if (levelList[i].IsEndLevel())
                {
                    EffectManager.instance.ActiveLevelUpEf();
                    levelList[i].gameObject.SetActive(false);
                    levelList[i + 1].gameObject.SetActive(true);
                    break;
                }
               
            }
        }
    }
    public void EndGame()
    {
        SceneManager.instance.LoadLevel(2);
    }
}