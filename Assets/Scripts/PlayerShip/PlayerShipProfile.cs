using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerShipProfile")]
public class PlayerShipProfile : ScriptableObject
{
    [SerializeField] private string shipName;
    [SerializeField] private float shipHp;
    [SerializeField] private float shipSpeed;
    [SerializeField] private float shipSpeedAttack;
    [SerializeField] private float shipBulletSpeed;
    [SerializeField] private float shipHpMax;
    [SerializeField] private float shipArmor;
    [SerializeField] private float shipDamage;
    public string ShipName { get => shipName; set => shipName = value; }
    public float ShipHp { get => shipHp; set => shipHp = value; }
    public float ShipSpeed { get => shipSpeed; set => shipSpeed = value; }
    public float ShipHpMax { get => shipHpMax; set => shipHpMax = value; }
    public float ShipArmor { get => shipArmor; set => shipArmor = value; }
    public float ShipSpeedAttack { get => shipSpeedAttack; set => shipSpeedAttack = value; }
    public float ShipDamage { get => shipDamage; set => shipDamage = value; }
    public float ShipBulletSpeed { get => shipBulletSpeed; set => shipBulletSpeed = value; }
}
