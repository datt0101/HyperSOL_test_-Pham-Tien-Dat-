using Unity;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    static public PlayerUI instance;
    [SerializeField] Image hpBar;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }

    public void UpdateHpBar()
    {
        hpBar.fillAmount = PlayerShipManager.instance.playerShipProfile.ShipHp / PlayerShipManager.instance.playerShipProfile.ShipHpMax;
    }


}