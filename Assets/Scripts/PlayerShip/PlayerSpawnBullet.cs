using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpawnBullet : SpawnBullet
{
    public List<Transform> bulletSpawnPointList;
    public GameObject bulletPrehaps;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > PlayerShipManager.instance.playerShipProfile.ShipSpeedAttack)
        {
            Spawn();
            timer = 0;
        }
    }
   
    public override void Spawn()
    {
        for (int i = 0; i < bulletSpawnPointList.Count; ++i)
        {
            Instantiate(bulletPrehaps, bulletSpawnPointList[i].position, bulletSpawnPointList[i].rotation);
        }
    }
}