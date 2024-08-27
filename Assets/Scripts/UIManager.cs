
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
   

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }
 
    public void TurnOn(GameObject panel)
    {
        //blackPanel.SetActive(true);
        panel.SetActive(true);
        panel.transform.localScale = Vector3.zero;
        panel.transform.DOScale(1f, .5f)
            .OnComplete(() =>
            {
                GameManager.instance.PauseGame();
            });

    }
    public void TurnOff(GameObject panel)
    {
        panel.transform.DOScale(0f, .5f)
            .OnComplete(() =>
            {
                GameManager.instance.ResumeGame();
                panel.SetActive(false);
            });


    }

}
