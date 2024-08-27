using System;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemySpawnSingleBullet : SpawnBullet
{
    private EnemyModel enemyModel;
    [SerializeField] private GameObject bulletPrefabs;
    [SerializeField] private Transform spawnBulletPoint;
    [SerializeField] private float timeSpawnMin, timeSpawnMax;
    private float timer;
    private float randomTime;
    
    private void Start()
    {
        enemyModel = GetComponent<EnemyModel>();
        bulletPrefabs.GetComponent<EnemyBullet>().enemyModel = enemyModel;
        randomTime = UnityEngine.Random.Range(timeSpawnMin,timeSpawnMax);
    }
    private void Update()
    {
        Spawn();
    }
    public override void Spawn()
    {
        timer += Time.deltaTime;
        if (timer > (enemyModel.enemyInstanceProfile.EnemyATKSpeed + randomTime))
        {
            Instantiate(bulletPrefabs, spawnBulletPoint.position, spawnBulletPoint.rotation);
            randomTime = UnityEngine.Random.Range(timeSpawnMin, timeSpawnMax);
            timer = 0;
        }
        
    }
}