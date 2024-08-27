using Unity;
using UnityEngine;

public class PlayerShipManager : MonoBehaviour
{
    static public PlayerShipManager instance; 
    public PlayerShipProfile playerShipProfile;
    public PlayerShipMovement playerShipMovement;
    public PlayerShipDamageReceiver playerShipDamageReceiver;
    public SpriteRenderer playerShipSpriteRenderer;
    public Collider2D playerShipCollider2D;
    public PlayerShipProfile playerShipDefaultProfile;
    public PlayerSpawnBullet playerSpawnBullet;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        playerShipMovement.enabled = true;
        playerShipMovement.GetComponent<SpriteRenderer>().enabled = true;
        playerShipMovement.GetComponent<BoxCollider2D>().enabled = true;
        playerSpawnBullet.enabled = true;
        InitShip();

    }
    private void InitShip()
    {
        playerShipProfile.ShipHp = playerShipDefaultProfile.ShipHp;
    }
    private void Reset()
    {
        LoadComponents();
    }

    public void LoadComponents()
    {
        playerShipMovement = GetComponentInChildren<PlayerShipMovement>();
        playerShipProfile = GetComponentInChildren<PlayerShipProfile>();
        playerShipDamageReceiver = GetComponentInChildren<PlayerShipDamageReceiver>();
        playerShipSpriteRenderer = playerShipMovement.GetComponent<SpriteRenderer>();
        playerShipCollider2D = playerShipMovement.GetComponent<BoxCollider2D>();
        playerSpawnBullet = GetComponentInChildren<PlayerSpawnBullet>();
    }
}