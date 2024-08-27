using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void PauseGame()
    {
        Time.timeScale = 0; 
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; 
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}