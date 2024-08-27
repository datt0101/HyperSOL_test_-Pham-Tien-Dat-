using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyList;
    private int enemyListLenght;
    private void Start()
    {
        enemyListLenght = enemyList.Count;
    }
    private void OnEnable()
    {
        foreach (var enemy in enemyList)
        {
            enemy.SetActive(true);
        }
    }
    public bool IsEndWave()
    {
        foreach (GameObject enemy in enemyList)
        {
            if (enemy.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }
}