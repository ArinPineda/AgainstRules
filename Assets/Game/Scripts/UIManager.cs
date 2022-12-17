using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject panelFood;
    public GameObject panelColors;
    public GameObject panelRoulete;
    public GameObject panelPause;

    public bool boolPause = true;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
           // DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (boolPause)
            {
                panelPause.SetActive(true);
                Time.timeScale = 0;
                boolPause = false;
            }
            else
            {
                panelPause.SetActive(false);
                Time.timeScale = 1;
                boolPause = true;
            }
        }



    }



    public void ActivePanelFood()
    {
        panelFood.SetActive(true);
    }

    public void ActivePanelRoulte()
    {
        panelRoulete.SetActive(true);


    }

    public void RestarScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    

}
