using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    static public SceneManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);

    }
    public void LoadLevel(int i)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(i);
    }    
}
