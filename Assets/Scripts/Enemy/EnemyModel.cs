using UnityEngine;

public class EnemyModel : MonoBehaviour
{ 
    public EnemyProfile enemyProfile;
    public EnemyProfile enemyInstanceProfile;
    public void OnEnable()
    {
        enemyInstanceProfile = Instantiate(enemyProfile);
    }
}