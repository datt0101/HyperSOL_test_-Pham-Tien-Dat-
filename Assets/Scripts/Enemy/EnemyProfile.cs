using Unity;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[CreateAssetMenu(menuName = "ScriptableObjects/EnemyProfile")]

public class EnemyProfile : ScriptableObject
{
    [SerializeField] private string enemyName;
    [SerializeField] private float enemyHP;
    [SerializeField] private float enemyHpMax;
    [SerializeField] private float enemyDamage;
    [SerializeField] private float enemyArmor;
    [SerializeField] private float enemySpeed;
    [SerializeField] private float enemyATKSpeed;
    [SerializeField] private float enemyBulletSpeed;
    [SerializeField] private int enemyScore;
    public string EnemyName { get => enemyName; set => enemyName = value; }
    public float EnemyHP { get => enemyHP; set => enemyHP = value; }
    public float EnemyDamage { get => enemyDamage; set => enemyDamage = value; }
    public float EnemyArmor { get => enemyArmor; set => enemyArmor = value; }
    public float EnemySpeed { get => enemySpeed; set => enemySpeed = value; }
    public float EnemyHpMax { get => enemyHpMax; set => enemyHpMax = value; }
    public float EnemyATKSpeed { get => enemyATKSpeed; set => enemyATKSpeed = value; }
    public int EnemyScore { get => enemyScore; set => enemyScore = value; }
    public float EnemyBulletSpeed { get => enemyBulletSpeed; set => enemyBulletSpeed = value; }

    public EnemyProfile(string name, float hp, float hpMax, float damage, float armor, float speed, float  atkSpeed,float bulletSpeed, int score)
    {
        enemyName = name;
        enemyHP = hp;
        enemyHpMax = hpMax;
        enemyDamage = damage;
        enemyArmor = armor;
        enemySpeed = speed;
        enemyATKSpeed = atkSpeed;
        enemyBulletSpeed = bulletSpeed;
        enemyScore = score;
    }
}
