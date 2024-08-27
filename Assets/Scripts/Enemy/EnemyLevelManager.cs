using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyLevelManager : MonoBehaviour
{
    [SerializeField] private List<EnemyWaveManager> enemyWaveList;
    private int enemyWaveListLenght;


    private void Start()
    {
        enemyWaveListLenght = enemyWaveList.Count;
    }
    public bool IsEndLevel()
    {
        for(int i = 0; i<enemyWaveListLenght; ++i)
        {
            if (enemyWaveList[i].gameObject.activeInHierarchy)
            {
                if (enemyWaveList[i].IsEndWave() && i == enemyWaveListLenght - 1)
                {
                    enemyWaveList[i].gameObject.SetActive(false);
                    return true;
                }

                if (enemyWaveList[i].IsEndWave())
                {
                    enemyWaveList[i].gameObject.SetActive(false);
                    enemyWaveList[i+1].gameObject.SetActive(true);
                }
                
                return false;
            }
        }
        return true;
    }
}